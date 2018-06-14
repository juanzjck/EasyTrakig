using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour {
    public GameObject canvas_login;
    public ListStudent studients;
    public Studient studientLogin;
   	// Use this for initialization
	void Start () {
        studients = new ListStudent();
        canvas_login = GameObject.FindGameObjectWithTag("singUp");
        
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
    public void singUp(){
        
        string name = GameObject.FindGameObjectWithTag("NameSingUP").GetComponent<InputField>().text;
        string email = GameObject.FindGameObjectWithTag("EmailSingUp").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassSingUP").GetComponent<InputField>().text;
        Studient studient = new Studient();
        studient.setName(name);
        studient.setMail(email);
        studient.setPassword(pass);
        studients.add(studient);
        string text = "succeful singUp" + studient.name;
        Debug.Log(text);
        GameObject.FindWithTag("SingUp").SetActive(false);

    }


    public void addSchedule(){
        string title= GameObject.FindGameObjectWithTag("TitleSignatureSingUP").GetComponent<InputField>().text;
        string profesor = GameObject.FindGameObjectWithTag("ProfesorSignatureSingUP").GetComponent<InputField>().text;
        int hourBegin = int.Parse(GameObject.FindGameObjectWithTag("HourBeginSignatureSingUP").GetComponent<InputField>().text);
        int hourEnd = int.Parse(GameObject.FindGameObjectWithTag("HourEndSignatureSingUP").GetComponent<InputField>().text);
        studientLogin.addSignature(new Signature(title,profesor,hourBegin,hourEnd));
        Debug.Log("succeful addSchedule");
    }

}
