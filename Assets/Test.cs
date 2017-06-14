using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数を引数で渡して、配列を出力
		DisplayArray(5);

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();

		// 攻撃
		lastboss.Attach();
		// 防御
		lastboss.Defence(3);
		// 10回魔法攻撃
		lastboss.Magic(10);
		// 1回魔法攻撃
		lastboss.Magic(1);
	}


	// Update is called once per frame
	void Update () {
		
	}

	void DisplayArray(int arrayNum) {
		// 配列arrayを宣言
		int []array = new int[arrayNum];
		// 配列に代入する乱数の最大値（配列の要素数5の場合100）
		int randomMaxRange = arrayNum * 20;
		// 好きな値で初期化
		for (int i = 0; i < array.Length; i++) {
			// 0〜randomMaxRangeの範囲の乱数で値を代入
			int randomNum = Random.Range(0, randomMaxRange);
			// randomNumが配列に含まれている限り回り続ける
			// メンターさんに教えてもらった下記だとエラーになったのは先頭で宣言すべきものが足りなかった？
			// while (array.Contains(randomNum))
			while (ArrayUtility.Contains(array, randomNum)) {
				//ランダム値を生成
				randomNum = Random.Range(0, randomMaxRange);
			}
			//値を設定
			array[i] = randomNum;
			// 値を表示
			Debug.Log("array[" + i + "]: " + array[i]);
		}

		// for文を使い、配列の各要素の値を逆順に表示
		Debug.Log("\nここから逆順表示");
		for (int i = 4; i >= 0; i--) {
			Debug.Log("array[" + i + "]: " + array[i]);
		}
	}
}

public class Boss {
	private int hp = 100; // 体力
	private int mp = 53; // MP
	private int power = 25; // 攻撃力

	// 物理攻撃
	public void Attach() {
		Debug.Log(this.power + "のダメージを与えた");
	}

	// 魔法攻撃
	public void Magic(int times) { // 回数を引数で指定
		Debug.Log(times + "回、魔法攻撃をするつもりだ。");
		for (int i = times; i >= 1; i--) {
			if (this.mp >= 5) {
				this.mp -= 5;
				Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
			} else {
				Debug.Log("MPが足りないため魔法が使えない。");
			}
		}
	}

	// 防御
	public void Defence(int damage) { // ダメージを引数で指定
		Debug.Log(damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}
}