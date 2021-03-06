﻿// // // *************************************************************************
// // // *                                                                       *
// // // * http://www.pentia.net/                                                *
// // // *                                                                       *
// // // * Copyright(C) Pentia A/S, 1997 - 2012. All rights reserved (R).        *
// // // *                                                                       *
// // // * LEGAL NOTICE: This is unpublished proprietary source code of Pentia.  *
// // // * The contents of this file are protected by copyright laws and         *
// // // * international copyright treaties, as well as other intellectual       *
// // // * property laws and treaties. These contents may not be extracted,      *
// // // * copied, modified or redistributed either as a whole or part thereof   *
// // // * in any form, and may not be used directly in, or to assist with, the  *
// // // * creation of derivative works of any nature without prior written      *
// // // * permission from Pentia. The above copyright notice does not           *
// // // * evidence any actual or intended publication of this file.             *
// // // *                                                                       *
// // // *************************************************************************

namespace WFFM8.To.SQL
{
    internal class Constants
    {
        internal struct Texts
        {
            internal struct Warning
            {
                internal const string IncorrectDateFromat = "Incorrect DateTime format.";
                
            }
        }

        internal struct Settings
        {
            internal struct Name
            {
                internal const string Connection = "WFM.ConnectionString";
                internal const string CsvDelimiter = "WFFM.SQLServer.SaveToDatabase.CsvDelimiter";
                internal const string ExportOptions = "WFFM.SQLServer.SaveToDatabase.ExportOptions";
            }
        }

        internal struct Url
        {
            internal const string ExportFromDataPage = "/Components/Framework/Form/Presentation/ExportFormData.aspx";
            internal const string ViewSQLData = "/Components/Framework/Form/Presentation/ViewSQLData.aspx";
        }

        internal struct QueryString
        {
            internal struct Name
            {
                internal const string ItemId = "itemId";
                internal const string ItemName = "itemName";
                internal const string DateRange = "dateRange";
            }
        }

        internal struct Response
        {
            internal struct ContentType
            {
                internal const string Csv = "text/csv; charset=UTF-8";
            }
            internal struct Charset
            {
                internal const string Utf8 = "UTF-8";
            }

            internal struct Header
            {
                internal struct ContentDisposition
                {
                    internal const string Name = "Content-Disposition";
                    internal const string AttachmentFilenameFormat = "attachment; filename={0}";
                }
            }
        }

        internal struct File
        {
            internal struct Exstensions
            {
                internal const string Csv = "csv";
            }
        }

        internal struct DateTime
        {
            internal const string TimeStampFormat = "yyyy-MM-dd HH:mm:ss";
            internal const string DateFormat = "d";
        }
    }

}