using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class Controller : MonoBehaviour {
    //Atributos 
    public GameObject canvas_login;
    public ListStudent students;
    private Student studentLogin;
    public GameObject menu;
    public bool login;
    public GameObject addSignatureCanvas;
    public GameObject ScheduleList;
    public GameObject textobject;
    public GameObject block;

   	// Use this for initialization
	void Start () {
        //busca los objetos con los tags correspondientes
        ScheduleList=GameObject.FindWithTag("ScheduleList");
        addSignatureCanvas=GameObject.FindWithTag("AddSignature");
        menu = GameObject.FindWithTag("Menu");
        canvas_login = GameObject.FindWithTag("LogIn");

        //Instanciamos objeto de la clase ListStudent, aqui se agregara los estudiantes registrados
        students = new ListStudent();

        //Set Cavas(UI) como modo  inicio
        canvas_login.SetActive(false);
        menu.SetActive(false);
        addSignatureCanvas.SetActive(false);
        ScheduleList.SetActive(false);
        //Estudiante en base de datos pruebas
        Student studient1 = new Student();
        studient1.setName("Juan Pablo");
        studient1.setMail("juan.salazar.zuniga@udla.edu.ec");
        studient1.setPassword("12345678");
        students.add(studient1);
      
	}   


	// Update is called once per frame
	void Update () {
		
	}
    // para realizar inicio de sesion
    public void logIn()
    {
        //busca los Game Objects con el tag correspondiente y obtiene los strings de dichos
        string email = GameObject.FindGameObjectWithTag("EmailLogIn").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassLogIn").GetComponent<InputField>().text;
       login=access(email,pass);
        if(login==true){ 
            Debug.Log("successful login");
            canvas_login.SetActive(false);
            studentLogin = students.searchMail(email);
            Debug.Log("name:"+ studentLogin.name);
            menu.SetActive(true);
        }else{

            Debug.Log("Not successful login");
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
        string text = "successful signUp" + student.name;
        Debug.Log(text);

        showLogIn();
        Debug.Log("Estudiante"+students.searchName("Juan").name);
    }

    public void compareUser(){

    }
    public void showLogIn(){
        GameObject.FindWithTag("SingUp").SetActive(false);
        canvas_login.SetActive(true);

    }

 
    public void showaddSignature(){
        
        addSignatureCanvas.SetActive(!addSignatureCanvas.active);
       
    }
    public void showScheduleList(){
        ScheduleList.SetActive(!ScheduleList.active);
         
       }
    public void showSingantures(){

        ScheduleList.GetComponent<ListSchedule>().ListSignatures(studentLogin.getSchedule().GetSignautes());
        showScheduleList();
    }
    public void AddSignature(){
        string title; 
        string profesor;
        if (login == true)
        {
            int hourBegin, hourend;
            title=GameObject.FindGameObjectWithTag("TitleSignature").GetComponent<InputField>().text;
            profesor= GameObject.FindGameObjectWithTag("ProfesorSignature").GetComponent<InputField>().text;
            hourBegin=int.Parse(GameObject.FindGameObjectWithTag("HourBeginSignatureSingUP").GetComponent<InputField>().text);
            hourend =int.Parse(GameObject.FindGameObjectWithTag("HourendSignatureSingUP").GetComponent<InputField>().text);
            Signature signature=new Signature();

           
            signature.setTitle(title);
            signature.setHourBegin(hourBegin);
            signature.setProfesor(profesor);
            signature.setHourend(hourend);
                     
            signature.setBlock(block);
            studentLogin.addSignature(signature);
            Debug.Log(signature.block.name);
            Debug.Log("tITULO"+signature.getTitle());
        }else{

            Debug.Log("Not login");
        }
            

    }
}
