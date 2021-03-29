﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using Models;


namespace LR4_Team_programming
{
    class ApiConnector
    {
        public static IEnumerable<Report> getReports()
        {
            IEnumerable<Report> jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/reports/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<IEnumerable<Report>>(jsonString);
            }
            return jsonDeserialized;
        }

        public static Report getReport(Report report)
        {
            Report jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(report.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<Report>(jsonString);
            }
            return jsonDeserialized;
        }


        public static void createReport(Report report)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/reports/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(report);
                streamWriter.Write(json);
            }

            Report jsonDeserialized;
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<Report>(result);
            }

            foreach (ReportLine line in report.report_lines)
                createReportLine(jsonDeserialized, line);
        }

        public static void deleteReport(Report report)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(report.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void editReport(Report report)
        {
            var oldReport = getReport(report);
            var oldCollection = oldReport.report_lines;
            var newCollection = report.report_lines;
            
            HashSet<ReportLine> oldSet = new HashSet<ReportLine>(oldCollection, new LineEqualityComparer());
            HashSet<ReportLine> newSet = new HashSet<ReportLine>(newCollection, new LineEqualityComparer());
            
            newSet.IntersectWith(oldSet);
            HashSet<ReportLine> sameElements = new HashSet<ReportLine>(newSet);
            newSet = new HashSet<ReportLine>(newCollection, new LineEqualityComparer());
          
            newSet.ExceptWith(oldSet);
            HashSet<ReportLine> elementsToAdd = new HashSet<ReportLine>(newSet);
            newSet = new HashSet<ReportLine>(newCollection, new LineEqualityComparer());


            oldSet.ExceptWith(newSet);
            HashSet<ReportLine> elementsToRemove = new HashSet<ReportLine>(oldSet);
            oldSet = new HashSet<ReportLine>(oldCollection, new LineEqualityComparer());

            foreach (ReportLine line in sameElements)
                editReportLine(line);

            foreach (ReportLine line in elementsToAdd)
                createReportLine(oldReport, line);

            foreach (ReportLine line in elementsToRemove)
                deleteReportLine(line);


            var httpWebRequest = (HttpWebRequest)WebRequest.Create(report.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(report);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static IEnumerable<ReportLine> getReportLine(Report report)
        {
            IEnumerable<ReportLine> jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/report-lines/?report_pk=" + report.report_pk.ToString());
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<IEnumerable<ReportLine>>(jsonString);
            }
            return jsonDeserialized;
        }

        public static void createReportLine(Report report, ReportLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/report-lines/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            line.report_pk = report.report_pk;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(line);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void deleteReportLine(ReportLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(line.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void editReportLine(ReportLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(line.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(line);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static IEnumerable<Vedomost> getVedomosts()
        {
            IEnumerable<Vedomost> jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/vedomosts/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<IEnumerable<Vedomost>>(jsonString);
            }
            return jsonDeserialized;
        }

        public static Vedomost getVedomost(Vedomost vedomost)
        {
            Vedomost jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(vedomost.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<Vedomost>(jsonString);
            }
            return jsonDeserialized;
        }

        public static void createVedomost(Vedomost vedomost)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/vedomosts/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(vedomost);
                streamWriter.Write(json);
            }

            Vedomost jsonDeserialized;
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<Vedomost>(result);
            }

            foreach (VedomostLine line in vedomost.vedomost_lines)
                createVedomostLine(jsonDeserialized, line);
        }

        public static void deleteVedomost(Vedomost vedomost)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(vedomost.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void editVedomost(Vedomost vedomost)
        {
            var oldVedomost = getVedomost(vedomost);
            var oldCollection = oldVedomost.vedomost_lines;
            var newCollection = vedomost.vedomost_lines;

            HashSet<VedomostLine> oldSet = new HashSet<VedomostLine>(oldCollection, new LineEqualityComparer());
            HashSet<VedomostLine> newSet = new HashSet<VedomostLine>(newCollection, new LineEqualityComparer());

            newSet.IntersectWith(oldSet);
            HashSet<VedomostLine> sameElements = new HashSet<VedomostLine>(newSet);
            newSet = new HashSet<VedomostLine>(newCollection, new LineEqualityComparer());

            newSet.ExceptWith(oldSet);
            HashSet<VedomostLine> elementsToAdd = new HashSet<VedomostLine>(newSet);
            newSet = new HashSet<VedomostLine>(newCollection, new LineEqualityComparer());


            oldSet.ExceptWith(newSet);
            HashSet<VedomostLine> elementsToRemove = new HashSet<VedomostLine>(oldSet);
            oldSet = new HashSet<VedomostLine>(oldCollection, new LineEqualityComparer());

            foreach (VedomostLine line in sameElements)
                editVedomostLine(line);

            foreach (VedomostLine line in elementsToAdd)
                createVedomostLine(oldVedomost, line);

            foreach (VedomostLine line in elementsToRemove)
                deleteVedomostLine(line);




            var httpWebRequest = (HttpWebRequest)WebRequest.Create(vedomost.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(vedomost);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }


        public static IEnumerable<VedomostLine> getVedomostLine(Vedomost vedomost)
        {
            IEnumerable<VedomostLine> jsonDeserialized;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/vedomost-lines/?vedomost_pk=" + vedomost.vedomost_pk.ToString());
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string jsonString = streamReader.ReadToEnd();
                jsonDeserialized = JsonConvert.DeserializeObject<IEnumerable<VedomostLine>>(jsonString);
            }
            return jsonDeserialized;
        }

        public static void createVedomostLine(Vedomost vedomost, VedomostLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://loloman.pythonanywhere.com/api/vedomost-lines/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            line.vedomost_pk = vedomost.vedomost_pk;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(line);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void deleteVedomostLine(VedomostLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(line.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public static void editVedomostLine(VedomostLine line)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(line.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(line);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        class LineEqualityComparer : IEqualityComparer<Line>
        {
            public bool Equals(Line l1, Line l2)
            {
                return l1.url == l2.url;
            }

            public int GetHashCode(Line line)
            {
                return line.url.GetHashCode();
            }
        }

    }
}