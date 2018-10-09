using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INonMono { }
public class NonMono1 : INonMono {
	int _i;
	char _c;
	public NonMono1 (int i, char c) {
		_i = i;
		_c = c;
	}
}

public class NonMono2 : INonMono {
	bool _b;
	public NonMono2 (bool b) {
		_b = b;
	}
}