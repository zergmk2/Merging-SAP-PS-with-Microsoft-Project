
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
  /// Return Parameter
  /// </summary>
  [RfcStructure(AbapName ="BAPIRET2" , Length = 548, Length2 = 1088)]
  [Serializable]
  public class BAPIRET2 : SAPStructure
  {
   

    /// <summary>
    /// Message type: S Success, E Error, W Warning, I Info, A Abort
    /// </summary>
 
    [RfcField(AbapName = "TYPE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 1, Length2 = 2, Offset = 0, Offset2 = 0)]
    [XmlElement("TYPE", Form=XmlSchemaForm.Unqualified)]
    public string Type
    { 
       get
       {
          return _Type;
       }
       set
       {
          _Type = value;
       }
    }
    private string _Type;


    /// <summary>
    /// Message Class
    /// </summary>
 
    [RfcField(AbapName = "ID", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 20, Length2 = 40, Offset = 1, Offset2 = 2)]
    [XmlElement("ID", Form=XmlSchemaForm.Unqualified)]
    public string Id
    { 
       get
       {
          return _Id;
       }
       set
       {
          _Id = value;
       }
    }
    private string _Id;


    /// <summary>
    /// Message Number
    /// </summary>
 
    [RfcField(AbapName = "NUMBER", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 3, Length2 = 6, Offset = 21, Offset2 = 42)]
    [XmlElement("NUMBER", Form=XmlSchemaForm.Unqualified)]
    public string Number
    { 
       get
       {
          return _Number;
       }
       set
       {
          _Number = value;
       }
    }
    private string _Number;


    /// <summary>
    /// Message Text
    /// </summary>
 
    [RfcField(AbapName = "MESSAGE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 220, Length2 = 440, Offset = 24, Offset2 = 48)]
    [XmlElement("MESSAGE", Form=XmlSchemaForm.Unqualified)]
    public string Message
    { 
       get
       {
          return _Message;
       }
       set
       {
          _Message = value;
       }
    }
    private string _Message;


    /// <summary>
    /// Application log: log number
    /// </summary>
 
    [RfcField(AbapName = "LOG_NO", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 20, Length2 = 40, Offset = 244, Offset2 = 488)]
    [XmlElement("LOG_NO", Form=XmlSchemaForm.Unqualified)]
    public string Log_No
    { 
       get
       {
          return _Log_No;
       }
       set
       {
          _Log_No = value;
       }
    }
    private string _Log_No;


    /// <summary>
    /// Application log: Internal message serial number
    /// </summary>
 
    [RfcField(AbapName = "LOG_MSG_NO", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 6, Length2 = 12, Offset = 264, Offset2 = 528)]
    [XmlElement("LOG_MSG_NO", Form=XmlSchemaForm.Unqualified)]
    public string Log_Msg_No
    { 
       get
       {
          return _Log_Msg_No;
       }
       set
       {
          _Log_Msg_No = value;
       }
    }
    private string _Log_Msg_No;


    /// <summary>
    /// Message Variable
    /// </summary>
 
    [RfcField(AbapName = "MESSAGE_V1", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 50, Length2 = 100, Offset = 270, Offset2 = 540)]
    [XmlElement("MESSAGE_V1", Form=XmlSchemaForm.Unqualified)]
    public string Message_V1
    { 
       get
       {
          return _Message_V1;
       }
       set
       {
          _Message_V1 = value;
       }
    }
    private string _Message_V1;


    /// <summary>
    /// Message Variable
    /// </summary>
 
    [RfcField(AbapName = "MESSAGE_V2", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 50, Length2 = 100, Offset = 320, Offset2 = 640)]
    [XmlElement("MESSAGE_V2", Form=XmlSchemaForm.Unqualified)]
    public string Message_V2
    { 
       get
       {
          return _Message_V2;
       }
       set
       {
          _Message_V2 = value;
       }
    }
    private string _Message_V2;


    /// <summary>
    /// Message Variable
    /// </summary>
 
    [RfcField(AbapName = "MESSAGE_V3", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 50, Length2 = 100, Offset = 370, Offset2 = 740)]
    [XmlElement("MESSAGE_V3", Form=XmlSchemaForm.Unqualified)]
    public string Message_V3
    { 
       get
       {
          return _Message_V3;
       }
       set
       {
          _Message_V3 = value;
       }
    }
    private string _Message_V3;


    /// <summary>
    /// Message Variable
    /// </summary>
 
    [RfcField(AbapName = "MESSAGE_V4", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 50, Length2 = 100, Offset = 420, Offset2 = 840)]
    [XmlElement("MESSAGE_V4", Form=XmlSchemaForm.Unqualified)]
    public string Message_V4
    { 
       get
       {
          return _Message_V4;
       }
       set
       {
          _Message_V4 = value;
       }
    }
    private string _Message_V4;


    /// <summary>
    /// Parameter Name
    /// </summary>
 
    [RfcField(AbapName = "PARAMETER", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 32, Length2 = 64, Offset = 470, Offset2 = 940)]
    [XmlElement("PARAMETER", Form=XmlSchemaForm.Unqualified)]
    public string Parameter
    { 
       get
       {
          return _Parameter;
       }
       set
       {
          _Parameter = value;
       }
    }
    private string _Parameter;


    /// <summary>
    /// Lines in parameter
    /// </summary>
 
    [RfcField(AbapName = "ROW", RfcType = RFCTYPE.RFCTYPE_INT, Length = 4, Length2 = 4, Offset = 504, Offset2 = 1004)]
    [XmlElement("ROW", Form=XmlSchemaForm.Unqualified)]
    public int Row
    { 
       get
       {
          return _Row;
       }
       set
       {
          _Row = value;
       }
    }
    private int _Row;


    /// <summary>
    /// Field in parameter
    /// </summary>
 
    [RfcField(AbapName = "FIELD", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 30, Length2 = 60, Offset = 508, Offset2 = 1008)]
    [XmlElement("FIELD", Form=XmlSchemaForm.Unqualified)]
    public string Field
    { 
       get
       {
          return _Field;
       }
       set
       {
          _Field = value;
       }
    }
    private string _Field;


    /// <summary>
    /// Logical system from which message originates
    /// </summary>
 
    [RfcField(AbapName = "SYSTEM", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 10, Length2 = 20, Offset = 538, Offset2 = 1068)]
    [XmlElement("SYSTEM", Form=XmlSchemaForm.Unqualified)]
    public string System
    { 
       get
       {
          return _System;
       }
       set
       {
          _System = value;
       }
    }
    private string _System;

  }

}
