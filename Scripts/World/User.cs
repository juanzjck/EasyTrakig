using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User {
    public string name,email,carrera,password;
    public int age;
    public User(){
        
    }
    public User(string name,string email,string carrera,int age){
        this.name = name;
        this.email = email;
        this.carrera = carrera;
        this.age = age;
    }
   
    public void setName(string name){
        if (name != ""){
            this.name = name;
           
        }else{
            Debug.Log("No es correcto");
        }
    }
    public void setPassword(string password)
    {
        this.password = password;
    }
    public void setMail(string email){
        this.email = email;
    }
    public void setCarrera(string carrera)
    {
        this.carrera= carrera;
    }
    public string getName(string name)
    {
        return name;
    }

    public string getMail(string email)
    {
        return email;
    }
    public void setAge(int age){
        this.age = age;
    }
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}

