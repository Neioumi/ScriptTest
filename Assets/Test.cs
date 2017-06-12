using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void DisplayArray() {
		// 要素が5個の配列arrayを宣言
		int[] array = new int[5];
		// 好きな値で初期化
		for (int i = 0; i < array.Length; i++) {
			// 0〜100の範囲の乱数で値を代入
			// TODO: 値が既に配列に含まれていたら、違う値を代入するようにしたい
			array[i] = Random.Range(0, 100);
			// 値を表示
			Debug.Log("array[" + i + "]: " + array[i]);
		}

		// for文を使い、配列の各要素の値を逆順に表示
		Debug.Log("\nここから逆順表示");
		for (int i = 4; i >= 0; i--) {
			Debug.Log("array[" + i + "]: " + array[i]);
		}
	}


	// Use this for initialization
	void Start () {
		// 配列を出力
		// TODO: 配列の数を引数にするとベター？
		DisplayArray();
	}


	// Update is called once per frame
	void Update () {
		
	}
}
