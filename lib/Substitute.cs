using System;
using System.Collections.Generic;
using System.Text;
public class Substitute {
    public int getValue(string key, string code)
    {
        Dictionary <char, int>keyMap = new Dictionary<char, int>();
        StringBuilder sb = new StringBuilder();
        int result = 0;
        for (int i=1; i<key.Length; i++){
            if (i+1 == 10){
              keyMap.Add(key[i], 0);
            }
            else{
                keyMap.Add(key[i], i+1);
            }
        }
        for (int j=0; j<code.Length; j++){
            if (keyMap.ContainsKey(code[j])){
                    sb.Append(keyMap[code[j]]);
                }
        }
                if (String.IsNullOrEmpty(sb.ToString()) != true)
                {
                    result = Int32.Parse(sb.ToString());
                }


        return result;
    }
}
