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
            var i = new DnsClient(IPAddress.Parse("37.209.192.9"), 5000).Resolve(DomainName.Parse("mili.one"),
                RecordType.Ns);
            Console.WriteLine(i.ReturnCode);
            foreach (var v in i.AuthorityRecords) Console.WriteLine(v.ToString());
            foreach (var v in i.AnswerRecords) Console.WriteLine(v.ToString());
            Console.ReadKey();
        }
    }
}
