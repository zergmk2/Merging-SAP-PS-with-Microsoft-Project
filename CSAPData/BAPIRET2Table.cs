
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
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace CSAPData
{
  /// <summary>
  /// A typed collection of BAPIRET2 elements.
  /// </summary>
  [Serializable]
  public class BAPIRET2Table : SAPTable 
  {
  
    /// <summary>
    /// Returns the element type BAPIRET2.
    /// </summary>
    /// <returns>The type BAPIRET2.</returns>
    public override Type GetElementType() 
    {
        return (typeof(BAPIRET2));
    }

    /// <summary>
    /// Creates an empty new row of type BAPIRET2.
    /// </summary>
    /// <returns>The newBAPIRET2.</returns>
    public override object CreateNewRow()
    { 
        return new BAPIRET2();
    }
     
    /// <summary>
    /// The indexer of the collection.
    /// </summary>
    public BAPIRET2 this[int index] 
    {
        get 
        {
            return ((BAPIRET2)(List[index]));
        }
        set 
        {
            List[index] = value;
        }
    }
        
    /// <summary>
    /// Adds a BAPIRET2 to the end of the collection.
    /// </summary>
    /// <param name="value">The BAPIRET2 to be added to the end of the collection.</param>
    /// <returns>The index of the newBAPIRET2.</returns>
    public int Add(BAPIRET2 value) 
    {
        return List.Add(value);
    }
        
    /// <summary>
    /// Inserts a BAPIRET2 into the collection at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which value should be inserted.</param>
    /// <param name="value">The BAPIRET2 to insert.</param>
    public void Insert(int index, BAPIRET2 value) 
    {
        List.Insert(index, value);
    }
        
    /// <summary>
    /// Searches for the specified BAPIRET2 and returnes the zero-based index of the first occurrence in the collection.
    /// </summary>
    /// <param name="value">The BAPIRET2 to locate in the collection.</param>
    /// <returns>The index of the object found or -1.</returns>
    public int IndexOf(BAPIRET2 value) 
    {
        return List.IndexOf(value);
    }
        
    /// <summary>
    /// Determines wheter an element is in the collection.
    /// </summary>
    /// <param name="value">The BAPIRET2 to locate in the collection.</param>
    /// <returns>True if found; else false.</returns>
    public bool Contains(BAPIRET2 value) 
    {
        return List.Contains(value);
    }
        
    /// <summary>
    /// Removes the first occurrence of the specified BAPIRET2 from the collection.
    /// </summary>
    /// <param name="value">The BAPIRET2 to remove from the collection.</param>
    public void Remove(BAPIRET2 value) 
    {
        List.Remove(value);
    }

    /// <summary>
    /// Copies the contents of the BAPIRET2Table to the specified one-dimensional array starting at the specified index in the target array.
    /// </summary>
    /// <param name="array">The one-dimensional destination array.</param>           
    /// <param name="index">The zero-based index in array at which copying begins.</param>           
    public void CopyTo(BAPIRET2[] array, int index) 
    {
        List.CopyTo(array, index);
	}
  }
}
