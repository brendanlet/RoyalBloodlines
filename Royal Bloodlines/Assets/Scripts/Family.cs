using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family
{
    private HashSet<Relative> _members;
    public HashSet<Relative> Members
    {
        get { return _members; }
        private set { _members = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
