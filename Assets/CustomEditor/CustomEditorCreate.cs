using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;
using System;

public class CustomEditorCreate : EditorWindow
{

    string objname = "objectname";
    Vector3 myPosition = new Vector3(0f, 0f, 0f);
    GUILayoutOption[] positionValues;
    Vector3 myRotation = new Vector3(0f, 0f, 0f);
    GUILayoutOption[] rotationValues;
    Vector3 myScale = new Vector3(1f, 1f, 1f);
    GUILayoutOption[] scaleValues;

    Color colorpicker= new Color32(223, 100, 100, 100);
    
    [MenuItem("Window/CustomTemplate")]
    public static void ShowWindow()
    {
        GetWindow<CustomEditorCreate>("EditUI");
    }

    [Serializable]
    public class Background
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Advertisement
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class AddText
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Icon
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Appheader
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class RatingBar
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Star1
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Star2
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Star3
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Star4
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;

    }

    [Serializable]
    public class Star5
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;
    }

    [Serializable]
    public class Free
    {
            public string objname;
            public float positionx, positiony, positionz;
            public float rotationx, rotationy, rotationz;
            public float scalex, scaley, scalez;
            public string colorpicked;

     }

    [Serializable]
    public class AppContent
        {
            public string objname;
            public float positionx, positiony, positionz;
            public float rotationx, rotationy, rotationz;
            public float scalex, scaley, scalez;
            public string colorpicked;

        }


    [Serializable]
    public class InstallBtn
    {
        public string objname;
        public float positionx, positiony, positionz;
        public float rotationx, rotationy, rotationz;
        public float scalex, scaley, scalez;
        public string colorpicked;
    }

    [Serializable]
    public class InstallText
            {
                public string objname;
                public float positionx, positiony, positionz;
                public float rotationx, rotationy, rotationz;
                public float scalex, scaley, scalez;
                public string colorpicked;

            }
        
    
    

    [Serializable]
    public class TemplateData
    {
        
        public Background Background = new Background();
        public Advertisement Advertisement = new Advertisement();
        public AddText AddText = new AddText();
        public Icon Icon = new Icon();
        public Appheader Appheader = new Appheader();
        public RatingBar RatingBar = new RatingBar();
        public Star1 Star1 = new Star1();
        public Star2 Star2 = new Star2();
        public Star3 Star3 = new Star3();
        public Star4 Star4 = new Star4();
        public Star5 Star5 = new Star5();
        public Free Free = new Free();
        public AppContent AppContent = new AppContent();
        public InstallBtn InstallBtn = new InstallBtn();
        public InstallText InstallText = new InstallText();
    }


    void OnGUI()
    {
        GUILayout.Label("Customize Your UI", EditorStyles.boldLabel);


        objname = EditorGUILayout.TextField("Name", objname);
        myPosition = EditorGUILayout.Vector3Field("Postion", myPosition, positionValues);
        myRotation = EditorGUILayout.Vector3Field("Rotation", myRotation, rotationValues);
        myScale = EditorGUILayout.Vector3Field("Scale", myScale, scaleValues);
        colorpicker = EditorGUILayout.ColorField("Color", colorpicker);


        if (GUILayout.Button("Load Template"))
        {
           
            GameObject i= Instantiate(Resources.Load("CustomTemplate", typeof(GameObject))) as GameObject;
            i.transform.parent = GameObject.Find("Panel").transform;
            i.transform.localPosition = new Vector3(-10f,-2f,-752f);
            i.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);


        }

        if (GUILayout.Button("Customize Template"))
        {
            GameObject SelectedName = GameObject.Find(objname);
            if (objname == "Advertisement" || objname == "Background" || objname == "Icon" || objname == "Star1" || objname == "Star2" || objname == "Star3" || objname == "Star4" || objname == "Star5" || objname == "InstallBtn")
            {
                SelectedName.GetComponent<Image>().color = colorpicker;
                SelectedName.GetComponent<Transform>().localScale = new Vector3(myScale.x, myScale.y, myScale.z);
                SelectedName.GetComponent<Transform>().localPosition = new Vector3(myPosition.x, myPosition.y, myPosition.z);
                SelectedName.GetComponent<Transform>().rotation = Quaternion.Euler(myRotation.x, myRotation.y, myRotation.z);
            }
            if (objname == "Appheader" || objname == "Free" || objname == "AppContent" || objname == "AddText" || objname == "InstallText")
            {

                SelectedName.GetComponent<TextMeshProUGUI>().color = colorpicker;

                SelectedName.GetComponent<Transform>().localScale = new Vector3(myScale.x, myScale.y, myScale.z);
                SelectedName.GetComponent<Transform>().localPosition = new Vector3(myPosition.x, myPosition.y, myPosition.z);
                SelectedName.GetComponent<Transform>().rotation = Quaternion.Euler(myRotation.x, myRotation.y, myRotation.z);
            }
            if (objname == "RatingBar")
            {
                GameObject star1 = GameObject.Find("Star1");
                GameObject star2 = GameObject.Find("Star2");
                GameObject star3 = GameObject.Find("Star3");
                GameObject star4 = GameObject.Find("Star4");
                GameObject star5 = GameObject.Find("Star5");

                SelectedName.GetComponent<Transform>().localScale = new Vector3(myScale.x, myScale.y, myScale.z);
                SelectedName.GetComponent<Transform>().localPosition = new Vector3(myPosition.x, myPosition.y, myPosition.z);
                SelectedName.GetComponent<Transform>().rotation = Quaternion.Euler(myRotation.x, myRotation.y, myRotation.z);
                star1.GetComponent<Image>().color = colorpicker;
                star2.GetComponent<Image>().color = colorpicker;
                star3.GetComponent<Image>().color = colorpicker;
                star4.GetComponent<Image>().color = colorpicker;
                star5.GetComponent<Image>().color = colorpicker;
            }
        }

        if (GUILayout.Button("Save To JSON"))
        {
            TemplateData data = new TemplateData();
            GameObject backgroundobject = GameObject.Find("Background");
            GameObject advertisementbtn = GameObject.Find("Advertisement");
            GameObject advertisementtext = GameObject.Find("AddText");
            GameObject iconobject = GameObject.Find("Icon");
            GameObject appheaderobject = GameObject.Find("Appheader");
            GameObject ratingbarobject = GameObject.Find("RatingBar");
            GameObject star1object = GameObject.Find("Star1");
            GameObject star2object = GameObject.Find("Star2");
            GameObject star3object = GameObject.Find("Star3"); 
            GameObject star4object = GameObject.Find("Star4");
            GameObject star5object = GameObject.Find("Star5");
            GameObject freeobject = GameObject.Find("Free");
            GameObject appcontentobject = GameObject.Find("AppContent");
            GameObject installbutton = GameObject.Find("InstallBtn");
            GameObject installbtntext = GameObject.Find("InstallText");

            data.Background.objname = backgroundobject.name;
            data.Background.positionx = backgroundobject.transform.localPosition.x;
            data.Background.positiony = backgroundobject.transform.localPosition.y;
            data.Background.positionz = backgroundobject.transform.localPosition.z;
            data.Background.rotationx = backgroundobject.transform.localRotation.x;
            data.Background.rotationy = backgroundobject.transform.localRotation.y;
            data.Background.rotationz = backgroundobject.transform.localRotation.z;
            data.Background.scalex = backgroundobject.transform.localScale.x;
            data.Background.scaley = backgroundobject.transform.localScale.y;
            data.Background.scalez = backgroundobject.transform.localScale.z;
            data.Background.colorpicked = backgroundobject.GetComponent<Image>().color.ToString();

            data.Advertisement.objname = advertisementbtn.name;
            data.Advertisement.positionx = advertisementbtn.transform.localPosition.x;
            data.Advertisement.positiony = advertisementbtn.transform.localPosition.y;
            data.Advertisement.positionz = advertisementbtn.transform.localPosition.z;
            data.Advertisement.rotationx = advertisementbtn.transform.localRotation.x;
            data.Advertisement.rotationy = advertisementbtn.transform.localRotation.y;
            data.Advertisement.rotationz = advertisementbtn.transform.localRotation.z;
            data.Advertisement.scalex = advertisementbtn.transform.localScale.x;
            data.Advertisement.scaley = advertisementbtn.transform.localScale.y;
            data.Advertisement.scalez = advertisementbtn.transform.localScale.z;
            data.Advertisement.colorpicked = advertisementbtn.GetComponent<Image>().color.ToString();

            data.AddText.objname = advertisementtext.name;
            data.AddText.positionx = advertisementtext.transform.localPosition.x;
            data.AddText.positiony = advertisementtext.transform.localPosition.y;
            data.AddText.positionz = advertisementtext.transform.localPosition.z;
            data.AddText.rotationx = advertisementtext.transform.localRotation.x;
            data.AddText.rotationy = advertisementtext.transform.localRotation.y;
            data.AddText.rotationz = advertisementtext.transform.localRotation.z;
            data.AddText.scalex = advertisementtext.transform.localScale.x;
            data.AddText.scaley = advertisementtext.transform.localScale.y;
            data.AddText.scalez = advertisementtext.transform.localScale.z;
            data.AddText.colorpicked = advertisementtext.GetComponent<TextMeshProUGUI>().color.ToString();

            data.Icon.objname = iconobject.name;
            data.Icon.positionx = iconobject.transform.localPosition.x;
            data.Icon.positiony = iconobject.transform.localPosition.y;
            data.Icon.positionz = iconobject.transform.localPosition.z;
            data.Icon.rotationx = iconobject.transform.localRotation.x;
            data.Icon.rotationy = iconobject.transform.localRotation.y;
            data.Icon.rotationz = iconobject.transform.localRotation.z;
            data.Icon.scalex = iconobject.transform.localScale.x;
            data.Icon.scaley = iconobject.transform.localScale.y;
            data.Icon.scalez = iconobject.transform.localScale.z;
            data.Icon.colorpicked = iconobject.GetComponent<Image>().color.ToString();

            data.Appheader.objname = appheaderobject.name;
            data.Appheader.positionx = appheaderobject.transform.localPosition.x;
            data.Appheader.positiony = appheaderobject.transform.localPosition.y;
            data.Appheader.positionz = appheaderobject.transform.localPosition.z;
            data.Appheader.rotationx = appheaderobject.transform.localRotation.x;
            data.Appheader.rotationy = appheaderobject.transform.localRotation.y;
            data.Appheader.rotationz = appheaderobject.transform.localRotation.z;
            data.Appheader.scalex = appheaderobject.transform.localScale.x;
            data.Appheader.scaley = appheaderobject.transform.localScale.y;
            data.Appheader.scalez = appheaderobject.transform.localScale.z;
            data.Appheader.colorpicked = appheaderobject.GetComponent<TextMeshProUGUI>().color.ToString();

            data.RatingBar.objname = ratingbarobject.name;
            data.RatingBar.positionx = ratingbarobject.transform.localPosition.x;
            data.RatingBar.positiony = ratingbarobject.transform.localPosition.y;
            data.RatingBar.positionz = ratingbarobject.transform.localPosition.z;
            data.RatingBar.rotationx = ratingbarobject.transform.localRotation.x;
            data.RatingBar.rotationy = ratingbarobject.transform.localRotation.y;
            data.RatingBar.rotationz = ratingbarobject.transform.localRotation.z;
            data.RatingBar.scalex = ratingbarobject.transform.localScale.x;
            data.RatingBar.scaley = ratingbarobject.transform.localScale.y;
            data.RatingBar.scalez = ratingbarobject.transform.localScale.z;
            data.RatingBar.colorpicked = star2object.GetComponent<Image>().color.ToString();


            data.Star1.objname = star1object.name;
            data.Star1.positionx = star1object.transform.localPosition.x;
            data.Star1.positiony = star1object.transform.localPosition.y;
            data.Star1.positionz = star1object.transform.localPosition.z;
            data.Star1.rotationx = star1object.transform.localRotation.x;
            data.Star1.rotationy = star1object.transform.localRotation.y;
            data.Star1.rotationz = star1object.transform.localRotation.z;
            data.Star1.scalex = star1object.transform.localScale.x;
            data.Star1.scaley = star1object.transform.localScale.y;
            data.Star1.scalez = star1object.transform.localScale.z;
            data.Star1.colorpicked = star1object.GetComponent<Image>().color.ToString();

            data.Star2.objname = star2object.name;
            data.Star2.positionx = star2object.transform.localPosition.x;
            data.Star2.positiony = star2object.transform.localPosition.y;
            data.Star2.positionz = star2object.transform.localPosition.z;
            data.Star2.rotationx = star2object.transform.localRotation.x;
            data.Star2.rotationy = star2object.transform.localRotation.y;
            data.Star2.rotationz = star2object.transform.localRotation.z;
            data.Star2.scalex = star2object.transform.localScale.x;
            data.Star2.scaley = star2object.transform.localScale.y;
            data.Star2.scalez = star2object.transform.localScale.z;
            data.Star2.colorpicked = star2object.GetComponent<Image>().color.ToString();

            data.Star3.objname = star3object.name;
            data.Star3.positionx = star3object.transform.localPosition.x;
            data.Star3.positiony = star3object.transform.localPosition.y;
            data.Star3.positionz = star3object.transform.localPosition.z;
            data.Star3.rotationx = star3object.transform.localRotation.x;
            data.Star3.rotationy = star3object.transform.localRotation.y;
            data.Star3.rotationz = star3object.transform.localRotation.z;
            data.Star3.scalex = star3object.transform.localScale.x;
            data.Star3.scaley = star3object.transform.localScale.y;
            data.Star3.scalez = star3object.transform.localScale.z;
            data.Star3.colorpicked = star3object.GetComponent<Image>().color.ToString();

            data.Star4.objname = star4object.name;
            data.Star4.positionx = star4object.transform.localPosition.x;
            data.Star4.positiony = star4object.transform.localPosition.y;
            data.Star4.positionz = star4object.transform.localPosition.z;
            data.Star4.rotationx = star4object.transform.localRotation.x;
            data.Star4.rotationy = star4object.transform.localRotation.y;
            data.Star4.rotationz = star4object.transform.localRotation.z;
            data.Star4.scalex = star4object.transform.localScale.x;
            data.Star4.scaley = star4object.transform.localScale.y;
            data.Star4.scalez = star4object.transform.localScale.z;
            data.Star4.colorpicked = star4object.GetComponent<Image>().color.ToString();

            data.Star5.objname = star5object.name;
            data.Star5.positionx = star5object.transform.localPosition.x;
            data.Star5.positiony = star5object.transform.localPosition.y;
            data.Star5.positionz = star5object.transform.localPosition.z;
            data.Star5.rotationx = star5object.transform.localRotation.x;
            data.Star5.rotationy = star5object.transform.localRotation.y;
            data.Star5.rotationz = star5object.transform.localRotation.z;
            data.Star5.scalex = star5object.transform.localScale.x;
            data.Star5.scaley = star5object.transform.localScale.y;
            data.Star5.scalez = star5object.transform.localScale.z;
            data.Star5.colorpicked = star5object.GetComponent<Image>().color.ToString();

            data.Free.objname = freeobject.name;
            data.Free.positionx = freeobject.transform.localPosition.x;
            data.Free.positiony = freeobject.transform.localPosition.y;
            data.Free.positionz = freeobject.transform.localPosition.z;
            data.Free.rotationx = freeobject.transform.localRotation.x;
            data.Free.rotationy = freeobject.transform.localRotation.y;
            data.Free.rotationz = freeobject.transform.localRotation.z;
            data.Free.scalex = freeobject.transform.localScale.x;
            data.Free.scaley = freeobject.transform.localScale.y;
            data.Free.scalez = freeobject.transform.localScale.z;
            data.Free.colorpicked = freeobject.GetComponent<TextMeshProUGUI>().color.ToString();

            data.AppContent.objname = appcontentobject.name;
            data.AppContent.positionx = appcontentobject.transform.localPosition.x;
            data.AppContent.positiony = appcontentobject.transform.localPosition.y;
            data.AppContent.positionz = appcontentobject.transform.localPosition.z;
            data.AppContent.rotationx = appcontentobject.transform.localRotation.x;
            data.AppContent.rotationy = appcontentobject.transform.localRotation.y;
            data.AppContent.rotationz = appcontentobject.transform.localRotation.z;
            data.AppContent.scalex = appcontentobject.transform.localScale.x;
            data.AppContent.scaley = appcontentobject.transform.localScale.y;
            data.AppContent.scalez = appcontentobject.transform.localScale.z;
            data.AppContent.colorpicked = appcontentobject.GetComponent<TextMeshProUGUI>().color.ToString();

            data.InstallBtn.objname = installbutton.name;
            data.InstallBtn.positionx = installbutton.transform.localPosition.x;
            data.InstallBtn.positiony = installbutton.transform.localPosition.y;
            data.InstallBtn.positionz = installbutton.transform.localPosition.z;
            data.InstallBtn.rotationx = installbutton.transform.localRotation.x;
            data.InstallBtn.rotationy = installbutton.transform.localRotation.y;
            data.InstallBtn.rotationz = installbutton.transform.localRotation.z;
            data.InstallBtn.scalex = installbutton.transform.localScale.x;
            data.InstallBtn.scaley = installbutton.transform.localScale.y;
            data.InstallBtn.scalez = installbutton.transform.localScale.z;
            data.InstallBtn.colorpicked = installbutton.GetComponent<Image>().color.ToString();

            data.InstallText.objname = installbtntext.name;
            data.InstallText.positionx = installbtntext.transform.localPosition.x;
            data.InstallText.positiony = installbtntext.transform.localPosition.y;
            data.InstallText.positionz = installbtntext.transform.localPosition.z;
            data.InstallText.rotationx = installbtntext.transform.localRotation.x;
            data.InstallText.rotationy = installbtntext.transform.localRotation.y;
            data.InstallText.rotationz = installbtntext.transform.localRotation.z;
            data.InstallText.scalex = installbtntext.transform.localScale.x;
            data.InstallText.scaley = installbtntext.transform.localScale.y;
            data.InstallText.scalez = installbtntext.transform.localScale.z;
            data.InstallText.colorpicked = installbtntext.GetComponent<TextMeshProUGUI>().color.ToString();
            
            string jsondata = JsonUtility.ToJson(data);
            string filepath = Application.persistentDataPath + "/CustomTemplateData.Json";
            System.IO.File.WriteAllText(filepath, jsondata);
        
        }

        
 }
}
