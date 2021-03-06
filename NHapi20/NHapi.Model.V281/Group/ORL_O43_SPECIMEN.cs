using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V281.Segment;
using NHapi.Model.V281.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V281.Group
{
///<summary>
///Represents the ORL_O43_SPECIMEN Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: SPM (Specimen) </li>
///<li>1: ORL_O43_SPECIMEN_OBSERVATION (a Group object) optional repeating</li>
///<li>2: NTE (Notes and Comments) optional repeating</li>
///<li>3: ORL_O43_SPECIMEN_CONTAINER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class ORL_O43_SPECIMEN : AbstractGroup {

	///<summary> 
	/// Creates a new ORL_O43_SPECIMEN Group.
	///</summary>
	public ORL_O43_SPECIMEN(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SPM), true, false);
	      this.add(typeof(ORL_O43_SPECIMEN_OBSERVATION), false, true);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(ORL_O43_SPECIMEN_CONTAINER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORL_O43_SPECIMEN - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SPM (Specimen) - creates it if necessary
	///</summary>
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.GetStructure("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORL_O43_SPECIMEN_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public ORL_O43_SPECIMEN_OBSERVATION GetSPECIMEN_OBSERVATION() {
	   ORL_O43_SPECIMEN_OBSERVATION ret = null;
	   try {
	      ret = (ORL_O43_SPECIMEN_OBSERVATION)this.GetStructure("SPECIMEN_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORL_O43_SPECIMEN_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORL_O43_SPECIMEN_OBSERVATION GetSPECIMEN_OBSERVATION(int rep) { 
	   return (ORL_O43_SPECIMEN_OBSERVATION)this.GetStructure("SPECIMEN_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O43_SPECIMEN_OBSERVATION 
	 */ 
	public int SPECIMEN_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SPECIMEN_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORL_O43_SPECIMEN_OBSERVATION results 
	 */ 
	public IEnumerable<ORL_O43_SPECIMEN_OBSERVATION> SPECIMEN_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < SPECIMEN_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (ORL_O43_SPECIMEN_OBSERVATION)this.GetStructure("SPECIMEN_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORL_O43_SPECIMEN_OBSERVATION
	///</summary>
	public ORL_O43_SPECIMEN_OBSERVATION AddSPECIMEN_OBSERVATION()
	{
		return this.AddStructure("SPECIMEN_OBSERVATION") as ORL_O43_SPECIMEN_OBSERVATION;
	}

	///<summary>
	///Removes the given ORL_O43_SPECIMEN_OBSERVATION
	///</summary>
	public void RemoveSPECIMEN_OBSERVATION(ORL_O43_SPECIMEN_OBSERVATION toRemove)
	{
		this.RemoveStructure("SPECIMEN_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the ORL_O43_SPECIMEN_OBSERVATION at the given index
	///</summary>
	public void RemoveSPECIMEN_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("SPECIMEN_OBSERVATION", index);
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of ORL_O43_SPECIMEN_CONTAINER (a Group object) - creates it if necessary
	///</summary>
	public ORL_O43_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER() {
	   ORL_O43_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (ORL_O43_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORL_O43_SPECIMEN_CONTAINER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORL_O43_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER(int rep) { 
	   return (ORL_O43_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O43_SPECIMEN_CONTAINER 
	 */ 
	public int SPECIMEN_CONTAINERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SPECIMEN_CONTAINER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORL_O43_SPECIMEN_CONTAINER results 
	 */ 
	public IEnumerable<ORL_O43_SPECIMEN_CONTAINER> SPECIMEN_CONTAINERs 
	{ 
		get
		{
			for (int rep = 0; rep < SPECIMEN_CONTAINERRepetitionsUsed; rep++)
			{
				yield return (ORL_O43_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORL_O43_SPECIMEN_CONTAINER
	///</summary>
	public ORL_O43_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER()
	{
		return this.AddStructure("SPECIMEN_CONTAINER") as ORL_O43_SPECIMEN_CONTAINER;
	}

	///<summary>
	///Removes the given ORL_O43_SPECIMEN_CONTAINER
	///</summary>
	public void RemoveSPECIMEN_CONTAINER(ORL_O43_SPECIMEN_CONTAINER toRemove)
	{
		this.RemoveStructure("SPECIMEN_CONTAINER", toRemove);
	}

	///<summary>
	///Removes the ORL_O43_SPECIMEN_CONTAINER at the given index
	///</summary>
	public void RemoveSPECIMEN_CONTAINERAt(int index)
	{
		this.RemoveRepetition("SPECIMEN_CONTAINER", index);
	}

}
}
