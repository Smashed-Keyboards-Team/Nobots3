﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProjectile : MonoBehaviour {
    
	//SCRIPT BASE DEL QUE HEREDAN TODOS LOS PROYECTILES
	
	public float speed = 5.0f;
 
    public abstract void FireProjectile(GameObject launcher, GameObject target, int damage, float attackSpeed);
}