using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ARSoft.Tools.Net;
using ARSoft.Tools.Net.Dns;

namespace Yuan
{
    class Program
    {
        static void Main(string[] args)
        {
            var dnsMessage = new DnsClient(IPAddress.Parse("37.209.192.9"), 5000).Resolve(DomainName.Parse("mili.one"),
                RecordType.Ns);
            Console.WriteLine(dnsMessage.ReturnCode);
            foreach (var i in dnsMessage.AuthorityRecords) Console.WriteLine(i);
            foreach (var i in dnsMessage.AnswerRecords) Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
