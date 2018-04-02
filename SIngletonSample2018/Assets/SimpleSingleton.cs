using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 以下のURL参考、というよりほぼコピペ
// http://waken.hatenablog.com/entry/2016/03/05/102928

// こっちは、MonoBehaviourが絡まないシングルトン
// データ管理マネージャ系に使う
public class SimpleSingleton<T> where T : class, new() {
    // 万一、外からコンストラクタを呼ばれたときに、ここで引っ掛ける
	protected SimpleSingleton() {
         Debug.Assert( null == _instance );
    }
    
	private static readonly T _instance = new T();
    
    public static T Instance {
         get {
             return _instance;
         }
    }
}
