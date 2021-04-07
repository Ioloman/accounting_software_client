using System.Collections.Generic;


namespace Models
{
    public class ReportLineParent
    {
        public virtual int report_line_pk { get; set; }
        static int number = 0;
        public ReportLineParent()
        {
            number--;
            report_line_pk = number;
        }
    }


    public class VedomostLineParent
    {
        public virtual int vedomost_line_pk { get; set; }
        static int number = 0;
        public VedomostLineParent()
        {
            number--;
            vedomost_line_pk = number;
        }
    }

    public class Detail
    {
        public string url { get; set; }
        public int detail_pk { get; set; }
        public string detail_name { get; set; }
        public string cipher_detail { get; set; }
    }

    public class ReportLine : ReportLineParent
    {
        public string url { get; set; }
        public override int report_line_pk { get; set; }
        public int report_pk { get; set; }
        public int detail_pk { get; set; }
        public int produced { get; set; }
        public Detail detail { get; set; }
        public int workshop_receiver_pk { get; set; }
        
    }

    public class Report
    {
        public string url { get; set; }
        public int report_pk { get; set; }
        public int doc_num { get; set; }
        public string date { get; set; }
        public int workshop_sender_pk { get; set; }
        public List<ReportLine> report_lines { get; set; }
    }
    public class VedomostLine : VedomostLineParent
    {
        public string url { get; set; }
        public override int vedomost_line_pk { get; set; }
        public int vedomost_pk { get; set; }
        public int detail_pk { get; set; }
        public int amount { get; set; }
        public Detail detail { get; set; }
    }

    public class Vedomost
    {
        public string url { get; set; }
        public int vedomost_pk { get; set; }
        public int doc_num { get; set; }
        public string creation_date { get; set; }
        public int workshop_pk { get; set; }
        public List<VedomostLine> vedomost_lines { get; set; }
    }

    public class Workshop
    {
        public string url { get; set; }
        public int workshop_pk { get; set; }
        public string workshop_name { get; set; }
        public string cipher_workshop { get; set; }
    }

    public class Leftover
    {
        public string url { get; set; }
        public int detail_pk { get; set; }
        public string detail_name { get; set; }
        public string cipher_detail { get; set; }
        public int amount { get; set; }
    }

    public class Accounting
    {
        public string url { get; set; }
        public int detail_pk { get; set; }
        public string detail_name { get; set; }
        public string cipher_detail { get; set; }
        public int actual_amount { get; set; }
        public int planned_amount { get; set; }
        public int deviation { get; set; }
    }

    public class AccountingResult
    {
        public object error { get; set; }
        public List<Accounting> accounting { get; set; }
    }

    public class LeftoversResponse
    {
        public List<Leftover> leftovers { get; set; }
        public List<object> stuck { get; set; }
        public object error { get; set; }
    }
}
