
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 8/29/2009
//     Created from Windows
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// 
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace CSAPData
{

  /// <summary>
  /// BAPI Structure for Milestones under Network Activity
  /// </summary>
  [RfcStructure(AbapName ="BAPI_ACT_MILESTONE" , Length = 165, Length2 = 324)]
  [Serializable]
  public class BAPI_ACT_MILESTONE : SAPStructure
  {
   

    /// <summary>
    /// Milestone number
    /// </summary>
 
    [RfcField(AbapName = "MILESTONE_NUMBER", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 12, Length2 = 24, Offset = 0, Offset2 = 0)]
    [XmlElement("MILESTONE_NUMBER", Form=XmlSchemaForm.Unqualified)]
    public string Milestone_Number
    { 
       get
       {
          return _Milestone_Number;
       }
       set
       {
          _Milestone_Number = value;
       }
    }
    private string _Milestone_Number;


    /// <summary>
    /// Network number
    /// </summary>
 
    [RfcField(AbapName = "NETWORK", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 12, Length2 = 24, Offset = 12, Offset2 = 24)]
    [XmlElement("NETWORK", Form=XmlSchemaForm.Unqualified)]
    public string Network
    { 
       get
       {
          return _Network;
       }
       set
       {
          _Network = value;
       }
    }
    private string _Network;


    /// <summary>
    /// Activity number in network and standard network
    /// </summary>
 
    [RfcField(AbapName = "ACTIVITY", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 4, Length2 = 8, Offset = 24, Offset2 = 48)]
    [XmlElement("ACTIVITY", Form=XmlSchemaForm.Unqualified)]
    public string Activity
    { 
       get
       {
          return _Activity;
       }
       set
       {
          _Activity = value;
       }
    }
    private string _Activity;


    /// <summary>
    /// Milestone usage
    /// </summary>
 
    [RfcField(AbapName = "MILESTONE_USAGE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 5, Length2 = 10, Offset = 28, Offset2 = 56)]
    [XmlElement("MILESTONE_USAGE", Form=XmlSchemaForm.Unqualified)]
    public string Milestone_Usage
    { 
       get
       {
          return _Milestone_Usage;
       }
       set
       {
          _Milestone_Usage = value;
       }
    }
    private string _Milestone_Usage;


    /// <summary>
    /// Description
    /// </summary>
 
    [RfcField(AbapName = "DESCRIPTION", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 40, Length2 = 80, Offset = 33, Offset2 = 66)]
    [XmlElement("DESCRIPTION", Form=XmlSchemaForm.Unqualified)]
    public string Description
    { 
       get
       {
          return _Description;
       }
       set
       {
          _Description = value;
       }
    }
    private string _Description;


    /// <summary>
    /// Scheduled milestone date (Basic)
    /// </summary>
 
    [RfcField(AbapName = "SCHED_MILESTONE_DATE_BASIC", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 73, Offset2 = 146)]
    [XmlElement("SCHED_MILESTONE_DATE_BASIC", Form=XmlSchemaForm.Unqualified)]
    public string Sched_Milestone_Date_Basic
    { 
       get
       {
          return _Sched_Milestone_Date_Basic;
       }
       set
       {
          _Sched_Milestone_Date_Basic = value;
       }
    }
    private string _Sched_Milestone_Date_Basic;


    /// <summary>
    /// Scheduled milestone time (Basic)
    /// </summary>
 
    [RfcField(AbapName = "SCHED_MILESTONE_TIME_BASIC", RfcType = RFCTYPE.RFCTYPE_TIME, Length = 6, Length2 = 12, Offset = 81, Offset2 = 162)]
    [XmlElement("SCHED_MILESTONE_TIME_BASIC", Form=XmlSchemaForm.Unqualified)]
    public string Sched_Milestone_Time_Basic
    { 
       get
       {
          return _Sched_Milestone_Time_Basic;
       }
       set
       {
          _Sched_Milestone_Time_Basic = value;
       }
    }
    private string _Sched_Milestone_Time_Basic;


    /// <summary>
    /// Scheduled milestone date (Forecast)
    /// </summary>
 
    [RfcField(AbapName = "SCHED_MILESTONE_DATE_FORECAST", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 87, Offset2 = 174)]
    [XmlElement("SCHED_MILESTONE_DATE_FORECAST", Form=XmlSchemaForm.Unqualified)]
    public string Sched_Milestone_Date_Forecast
    { 
       get
       {
          return _Sched_Milestone_Date_Forecast;
       }
       set
       {
          _Sched_Milestone_Date_Forecast = value;
       }
    }
    private string _Sched_Milestone_Date_Forecast;


    /// <summary>
    /// Scheduled milestone time (Forecast)
    /// </summary>
 
    [RfcField(AbapName = "SCHED_MILESTONE_TIME_FORECAST", RfcType = RFCTYPE.RFCTYPE_TIME, Length = 6, Length2 = 12, Offset = 95, Offset2 = 190)]
    [XmlElement("SCHED_MILESTONE_TIME_FORECAST", Form=XmlSchemaForm.Unqualified)]
    public string Sched_Milestone_Time_Forecast
    { 
       get
       {
          return _Sched_Milestone_Time_Forecast;
       }
       set
       {
          _Sched_Milestone_Time_Forecast = value;
       }
    }
    private string _Sched_Milestone_Time_Forecast;


    /// <summary>
    /// Fixed milestone date (basic)
    /// </summary>
 
    [RfcField(AbapName = "FIXED_MILESTONE_DATE_BASIC", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 101, Offset2 = 202)]
    [XmlElement("FIXED_MILESTONE_DATE_BASIC", Form=XmlSchemaForm.Unqualified)]
    public string Fixed_Milestone_Date_Basic
    { 
       get
       {
          return _Fixed_Milestone_Date_Basic;
       }
       set
       {
          _Fixed_Milestone_Date_Basic = value;
       }
    }
    private string _Fixed_Milestone_Date_Basic;


    /// <summary>
    /// Fixed milestone time (Basic)
    /// </summary>
 
    [RfcField(AbapName = "FIXED_MILESTONE_TIME_BASIC", RfcType = RFCTYPE.RFCTYPE_TIME, Length = 6, Length2 = 12, Offset = 109, Offset2 = 218)]
    [XmlElement("FIXED_MILESTONE_TIME_BASIC", Form=XmlSchemaForm.Unqualified)]
    public string Fixed_Milestone_Time_Basic
    { 
       get
       {
          return _Fixed_Milestone_Time_Basic;
       }
       set
       {
          _Fixed_Milestone_Time_Basic = value;
       }
    }
    private string _Fixed_Milestone_Time_Basic;


    /// <summary>
    /// Fixed milestone date (F)
    /// </summary>
 
    [RfcField(AbapName = "FIXED_MILESTONE_DATE_FORECAST", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 115, Offset2 = 230)]
    [XmlElement("FIXED_MILESTONE_DATE_FORECAST", Form=XmlSchemaForm.Unqualified)]
    public string Fixed_Milestone_Date_Forecast
    { 
       get
       {
          return _Fixed_Milestone_Date_Forecast;
       }
       set
       {
          _Fixed_Milestone_Date_Forecast = value;
       }
    }
    private string _Fixed_Milestone_Date_Forecast;


    /// <summary>
    /// Fixed milestone time (F)
    /// </summary>
 
    [RfcField(AbapName = "FIXED_MILESTONE_TIME_FORECAST", RfcType = RFCTYPE.RFCTYPE_TIME, Length = 6, Length2 = 12, Offset = 123, Offset2 = 246)]
    [XmlElement("FIXED_MILESTONE_TIME_FORECAST", Form=XmlSchemaForm.Unqualified)]
    public string Fixed_Milestone_Time_Forecast
    { 
       get
       {
          return _Fixed_Milestone_Time_Forecast;
       }
       set
       {
          _Fixed_Milestone_Time_Forecast = value;
       }
    }
    private string _Fixed_Milestone_Time_Forecast;


    /// <summary>
    /// Actual date (Milestone met)
    /// </summary>
 
    [RfcField(AbapName = "ACTUAL_DATE", RfcType = RFCTYPE.RFCTYPE_DATE, Length = 8, Length2 = 16, Offset = 129, Offset2 = 258)]
    [XmlElement("ACTUAL_DATE", Form=XmlSchemaForm.Unqualified)]
    public string Actual_Date
    { 
       get
       {
          return _Actual_Date;
       }
       set
       {
          _Actual_Date = value;
       }
    }
    private string _Actual_Date;


    /// <summary>
    /// Actual date/time (Milestone met)
    /// </summary>
 
    [RfcField(AbapName = "ACTUAL_TIME", RfcType = RFCTYPE.RFCTYPE_TIME, Length = 6, Length2 = 12, Offset = 137, Offset2 = 274)]
    [XmlElement("ACTUAL_TIME", Form=XmlSchemaForm.Unqualified)]
    public string Actual_Time
    { 
       get
       {
          return _Actual_Time;
       }
       set
       {
          _Actual_Time = value;
       }
    }
    private string _Actual_Time;


    /// <summary>
    /// Indicator: Latest dates
    /// </summary>
 
    [RfcField(AbapName = "LATEST_DATES_INDICATOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 143, Offset2 = 286)]
    [XmlElement("LATEST_DATES_INDICATOR", Form=XmlSchemaForm.Unqualified)]
    public string Latest_Dates_Indicator
    { 
       get
       {
          return _Latest_Dates_Indicator;
       }
       set
       {
          _Latest_Dates_Indicator = value;
       }
    }
    private string _Latest_Dates_Indicator;


    /// <summary>
    /// Ind: Reference for offset (start/finish activity date)
    /// </summary>
 
    [RfcField(AbapName = "OFFSET_START_END_INDICATOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 144, Offset2 = 288)]
    [XmlElement("OFFSET_START_END_INDICATOR", Form=XmlSchemaForm.Unqualified)]
    public string Offset_Start_End_Indicator
    { 
       get
       {
          return _Offset_Start_End_Indicator;
       }
       set
       {
          _Offset_Start_End_Indicator = value;
       }
    }
    private string _Offset_Start_End_Indicator;


    /// <summary>
    /// Offset for milestone date
    /// </summary>
 
    [RfcField(AbapName = "OFFSET_MILESTONE_DATE", RfcType = RFCTYPE.RFCTYPE_BCD, Length = 3, Length2 = 3, Offset = 145, Offset2 = 290)]
    [XmlElement("OFFSET_MILESTONE_DATE", Form=XmlSchemaForm.Unqualified)]
    public Decimal Offset_Milestone_Date
    { 
       get
       {
          return _Offset_Milestone_Date;
       }
       set
       {
          _Offset_Milestone_Date = value;
       }
    }
    private Decimal _Offset_Milestone_Date;


    /// <summary>
    /// Time unit for offset of milestone date
    /// </summary>
 
    [RfcField(AbapName = "OFFSET_MILESTONE_DATE_UNIT", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 3, Length2 = 6, Offset = 148, Offset2 = 294)]
    [XmlElement("OFFSET_MILESTONE_DATE_UNIT", Form=XmlSchemaForm.Unqualified)]
    public string Offset_Milestone_Date_Unit
    { 
       get
       {
          return _Offset_Milestone_Date_Unit;
       }
       set
       {
          _Offset_Milestone_Date_Unit = value;
       }
    }
    private string _Offset_Milestone_Date_Unit;


    /// <summary>
    /// ISO code for unit of measurement
    /// </summary>
 
    [RfcField(AbapName = "OFFSET_MILESTONE_DATE_UNIT_ISO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 3, Length2 = 6, Offset = 151, Offset2 = 300)]
    [XmlElement("OFFSET_MILESTONE_DATE_UNIT_ISO", Form=XmlSchemaForm.Unqualified)]
    public string Offset_Milestone_Date_Unit_Iso
    { 
       get
       {
          return _Offset_Milestone_Date_Unit_Iso;
       }
       set
       {
          _Offset_Milestone_Date_Unit_Iso = value;
       }
    }
    private string _Offset_Milestone_Date_Unit_Iso;


    /// <summary>
    /// Percentual offset of milestone to activity date
    /// </summary>
 
    [RfcField(AbapName = "OFFSET_PERCENTAGE", RfcType = RFCTYPE.RFCTYPE_BCD, Length = 2, Length2 = 2, Offset = 154, Offset2 = 306)]
    [XmlElement("OFFSET_PERCENTAGE", Form=XmlSchemaForm.Unqualified)]
    public Decimal Offset_Percentage
    { 
       get
       {
          return _Offset_Percentage;
       }
       set
       {
          _Offset_Percentage = value;
       }
    }
    private Decimal _Offset_Percentage;


    /// <summary>
    /// Milestone relevant for trend analysis
    /// </summary>
 
    [RfcField(AbapName = "TREND_ANALYSIS_INDICATOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 156, Offset2 = 308)]
    [XmlElement("TREND_ANALYSIS_INDICATOR", Form=XmlSchemaForm.Unqualified)]
    public string Trend_Analysis_Indicator
    { 
       get
       {
          return _Trend_Analysis_Indicator;
       }
       set
       {
          _Trend_Analysis_Indicator = value;
       }
    }
    private string _Trend_Analysis_Indicator;


    /// <summary>
    /// Milestone relevant for progress analysis
    /// </summary>
 
    [RfcField(AbapName = "EARNED_VALUE_INDICATOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 157, Offset2 = 310)]
    [XmlElement("EARNED_VALUE_INDICATOR", Form=XmlSchemaForm.Unqualified)]
    public string Earned_Value_Indicator
    { 
       get
       {
          return _Earned_Value_Indicator;
       }
       set
       {
          _Earned_Value_Indicator = value;
       }
    }
    private string _Earned_Value_Indicator;


    /// <summary>
    /// Percentage of completion (%)
    /// </summary>
 
    [RfcField(AbapName = "PERCENTAGE_OF_COMPLETION", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 3, Length2 = 6, Offset = 158, Offset2 = 312)]
    [XmlElement("PERCENTAGE_OF_COMPLETION", Form=XmlSchemaForm.Unqualified)]
    public string Percentage_Of_Completion
    { 
       get
       {
          return _Percentage_Of_Completion;
       }
       set
       {
          _Percentage_Of_Completion = value;
       }
    }
    private string _Percentage_Of_Completion;


    /// <summary>
    /// Milestone is relevant for date in sales document
    /// </summary>
 
    [RfcField(AbapName = "SALES_DOC_DATE_INIDICATOR", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 161, Offset2 = 318)]
    [XmlElement("SALES_DOC_DATE_INIDICATOR", Form=XmlSchemaForm.Unqualified)]
    public string Sales_Doc_Date_Inidicator
    { 
       get
       {
          return _Sales_Doc_Date_Inidicator;
       }
       set
       {
          _Sales_Doc_Date_Inidicator = value;
       }
    }
    private string _Sales_Doc_Date_Inidicator;


    /// <summary>
    /// Percentage of value to be invoiced
    /// </summary>
 
    [RfcField(AbapName = "INVOICE_PERCENTAGE", RfcType = RFCTYPE.RFCTYPE_BCD, Length = 3, Length2 = 3, Decimals = 2, Offset = 162, Offset2 = 320)]
    [XmlElement("INVOICE_PERCENTAGE", Form=XmlSchemaForm.Unqualified)]
    public Decimal Invoice_Percentage
    { 
       get
       {
          return _Invoice_Percentage;
       }
       set
       {
          _Invoice_Percentage = value;
       }
    }
    private Decimal _Invoice_Percentage;

  }

}
