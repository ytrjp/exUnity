// ======================================================================================
// File         : exRuntimeDebugger.cs
// Author       : Wu Jie 
// Last Change  : 02/19/2012 | 21:20:14 PM | Sunday,February
// Description  : 
// ======================================================================================

///////////////////////////////////////////////////////////////////////////////
// usings
///////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

///////////////////////////////////////////////////////////////////////////////
// defines
///////////////////////////////////////////////////////////////////////////////

public class exRuntimeDebugger : MonoBehaviour {

    ///////////////////////////////////////////////////////////////////////////////
    // properites
    ///////////////////////////////////////////////////////////////////////////////

    public static exRuntimeDebugger instance = null;

    ///////////////////////////////////////////////////////////////////////////////
    // functions
    ///////////////////////////////////////////////////////////////////////////////

    // ------------------------------------------------------------------ 
    // Desc: 
    // ------------------------------------------------------------------ 

    void Awake () {
        if ( instance == null ) {
            instance = this;
            GameObject.DontDestroyOnLoad(instance.gameObject);
        }
    }
}
