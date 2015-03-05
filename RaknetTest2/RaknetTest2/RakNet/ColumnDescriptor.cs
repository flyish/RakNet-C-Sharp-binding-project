/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class ColumnDescriptor : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ColumnDescriptor(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ColumnDescriptor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ColumnDescriptor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_ColumnDescriptor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ColumnDescriptor() : this(RakNetPINVOKE.new_ColumnDescriptor__SWIG_0(), true) {
  }

  public ColumnDescriptor(string cn, Table.ColumnType ct) : this(RakNetPINVOKE.new_ColumnDescriptor__SWIG_1(cn, (int)ct), true) {
  }

  public string columnName {
    set {
      RakNetPINVOKE.ColumnDescriptor_columnName_set(swigCPtr, value);
    } 
    get {
      string ret = RakNetPINVOKE.ColumnDescriptor_columnName_get(swigCPtr);
      return ret;
    } 
  }

  public Table.ColumnType columnType {
    set {
      RakNetPINVOKE.ColumnDescriptor_columnType_set(swigCPtr, (int)value);
    } 
    get {
      Table.ColumnType ret = (Table.ColumnType)RakNetPINVOKE.ColumnDescriptor_columnType_get(swigCPtr);
      return ret;
    } 
  }

}

}
