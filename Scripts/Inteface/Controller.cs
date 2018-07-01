using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class Controller : MonoBehaviour {
    public GameObject canvas_login;
    public ListStudent students;
    private Student studentLogin;
    public GameObject menu;
    public bool login;
    public GameObject addSignatureCanvas;
    public GameObject ScheduleList;
    public GameObject textobject;
   	// Use this for initialization
	void Start () {
        ScheduleList=GameObject.FindWithTag("ScheduleList");
        addSignatureCanvas=GameObject.FindWithTag("AddSignature");
        students = new ListStudent();
        menu= GameObject.FindWithTag("Menu");
        canvas_login=GameObject.FindWithTag("LogIn");
        canvas_login.SetActive(false);
        menu.SetActive(false);
        addSignatureCanvas.SetActive(false);
        ScheduleList.SetActive(false);
        Debug.Log("Hola luci");
        Student studiante = new Student();
        studiante.setAge(12);
        studiante.setMail("juan");
        studiante.setName("juan");
        studiante.setCarrera("juansd");
        studiante.setPassword("sdf23");
        studentLogin = studiante;
        Signature signaturetest = new Signature("hola","profe",20,23);
       
        studentLogin.addSignature(signaturetest);
      
      
	}   


	// Update is called once per frame
	void Update () {
		
	}
    public void ScheduleListShow(){
        ScheduleList.SetActive(true);
        for (int i=0; i < studentLogin.schedule.siganatures.length();i++){
            string text = studentLogin.schedule.siganatures.getInd(i).ToString();
            Instantiate(textobject);
            textobject.GetComponent<Text>().text = text;
            ScheduleList.transform.parent = textobject.transform;
        }

    }
    public void logIn()
    {
        string email = GameObject.FindGameObjectWithTag("EmailLogIn").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassLogIn").GetComponent<InputField>().text;
       login=access(email,pass);
        if(login==true){
            Debug.Log("succeful login");
            canvas_login.SetActive(false);
            studentLogin = students.searchMail(email);
            Debug.Log("name:"+ studentLogin.name);
            menu.SetActive(true);
        }else{

            Debug.Log("Not succeful login");
        }

    }
    private bool access(string email, string pass){
       
        return students.passMatchAndMail(email, pass);
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
        canvas_login.SetActive(true);
        Debug.Log("Estudiante"+students.searchName("Juan").name);
    }

    public void compareUser(){

    }

 
    public void showaddSignature(){
        
        addSignatureCanvas.SetActive(true);

    }
    public void showScheduleList(){
        ScheduleList.SetActive(true);
        ListSignaute signautes = studentLogin.getSchedule().GetSignaute();
        for (int i = 0; i < signautes.length();i++){
            GameObject Schedule = GameObject.FindWithTag("Schedule");
        GameObject text= Instantiate(textobject);
        text.transform.position = Schedule.GetComponentInParent<Transform>().position;
        


        }
       
       }
    public void AddSignature(){
        string title, profesor;
        if (login == true)
        {
            int hourBegin, hourend;
            title=GameObject.FindGameObjectWithTag("TitleSignature").GetComponent<InputField>().text;
            profesor= GameObject.FindGameObjectWithTag("ProfesorSignature").GetComponent<InputField>().text;
            hourBegin=int.Parse(GameObject.FindGameObjectWithTag("HourBeginSignatureSingUP").GetComponent<InputField>().text);
            hourend =int.Parse(GameObject.FindGameObjectWithTag("HourendSignatureSingUP").GetComponent<InputField>().text);
            Signature signature = new Signature(title, profesor, hourBegin, hourend);
            studentLogin.addSignature(signature);
            showScheduleList();
        }else{

            Debug.Log("Not login");
        }
            

    }
}
