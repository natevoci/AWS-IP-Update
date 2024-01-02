using Amazon.Route53.Model;
using Amazon.Route53;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWS_IP_Update
{
    internal class IPUpdater
    {
        public static async void Update() {
            try
            {
                var accessKey = Settings.Default.AccessKeyID;
                var secret = Settings.Default.SecretAccessKey;
                var zoneID = Settings.Default.ZoneID;
                var recordSet = Settings.Default.RecordSet;
                var ipProvider = Settings.Default.IPProvider;
                var lastIPAddress = Settings.Default.LastIPAddress;

                Logger.WriteLine($"Detecting IP Address...");
                var ipAddress = "";
                using (var client = new HttpClient())
                {
                    ipAddress = (await client.GetStringAsync(ipProvider)).Trim();
                }

                if (lastIPAddress != ipAddress)
                {
                    Logger.WriteLine($"Detected IP Address change to ${ipAddress}");

                    using (var r53Client = new AmazonRoute53Client(accessKey, secret))
                    {
                        var listResponse = await r53Client.ListResourceRecordSetsAsync(new ListResourceRecordSetsRequest(zoneID));

                        var resourceRecordSet = new ResourceRecordSet()
                        {
                            Name = recordSet,
                            Type = "A",
                            TTL = 300,
                            ResourceRecords = new List<ResourceRecord>()
                            {
                                new ResourceRecord()
                                {
                                    Value = ipAddress
                                }
                            }
                        };
                        var changeBatch = new ChangeBatch(new List<Change>() {
                            new Change(ChangeAction.UPSERT, resourceRecordSet)
                        });
                        var request = new ChangeResourceRecordSetsRequest(zoneID, changeBatch);

                        var changeResponse = await r53Client.ChangeResourceRecordSetsAsync(request);

                        Logger.WriteLine($"Change request submitted: {changeResponse.ChangeInfo.Status}");
                    }

                    Settings.Default.LastIPAddress = ipAddress;
                    Settings.Default.Save();

                    Logger.WriteLine($"IP Address successfully changed to ${ipAddress}");
                }
                else
                {
                    Logger.WriteLine($"IP Address has not changed");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Change request failed: {ex.ToString()}");
                Logger.WriteLine($"Unexpected error: {ex.ToString()}");
            }
        }

    }
}
