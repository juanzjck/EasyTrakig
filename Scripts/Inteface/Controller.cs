using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    public GameObject canvas_login;
    public ListStudent students;
    public Student studentLogin;
   	// Use this for initialization
	void Start () {
        students = new ListStudent();
        canvas_login = GameObject.FindGameObjectWithTag("signUp");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void logIn(){
        string email = GameObject.FindGameObjectWithTag("EmailLogIn").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassLogIn").GetComponent<InputField>().text;

    }

    private bool access(string email, string pass){
       
        return false;
    }
    public void signUp(){
        
        string name = GameObject.FindGameObjectWithTag("NameSingUP").GetComponent<InputField>().text;
        string email = GameObject.FindGameObjectWithTag("EmailSingUp").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassSingUP").GetComponent<InputField>().text;
        Student student = new Student();
        student.setName(name);
        student.setMail(email);
        student.setPassword(pass);
        students.add(student);
        string text = "succeful signUp" + student.name;
        Debug.Log(text);
        GameObject.FindWithTag("SingUp").SetActive(false);
        Debug.Log(students.searchName("juan").name);
    }

    public void compareUser(){

    }

    public void addSchedule(){
        string title= GameObject.FindGameObjectWithTag("TitleSignatureSingUP").GetComponent<InputField>().text;
        string profesor = GameObject.FindGameObjectWithTag("ProfesorSignatureSingUP").GetComponent<InputField>().text;
        int hourBegin = int.Parse(GameObject.FindGameObjectWithTag("HourBeginSignatureSingUP").GetComponent<InputField>().text);
        int hourEnd = int.Parse(GameObject.FindGameObjectWithTag("HourEndSignatureSingUP").GetComponent<InputField>().text);
        studentLogin.addSignature(new Signature(title,profesor,hourBegin,hourEnd));
        Debug.Log("succeful addSchedule");
    }

}
