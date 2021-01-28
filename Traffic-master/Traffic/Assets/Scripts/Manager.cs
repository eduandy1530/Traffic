using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using System;

public class Manager : MonoBehaviour
{
    public List<GameObject> s1;
    public List<GameObject> s2;
    public List<GameObject> s3;
    public List<GameObject> s4;
    public bool UnoThree;
    public bool TwoFour;
    public float velocity1;
    public float velocity2;
    public float velocity3;
    public float velocity4;
    public SliderTimer sliderTimer;

    //0 = verde --  1 = Amarillo -- 2 = Red

    void Start()
    {
        allOff();
        StartCoroutine(trafficLightIEnumerator());
        Time.timeScale = sliderTimer.timer;
    }


    private void Update()
    {
        Time.timeScale = sliderTimer.timer;
    }

    async void trafficLightAsync()
    {
        while (true)
        {

            SemaforoVerde_1_3();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            Semaforo1Amarillo_1_3();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            SemaforoVerde_2_4();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            SemaforoAmarillo_2_4();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));

        }
    }



    // void trafficLightThreads()
    //{
    //    while (true)
    //    {

    //        SemaforoVerde_1_3();

            //await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            //Semaforo1Amarillo_1_3();

            //await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            //SemaforoVerde_2_4();

            //await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            //SemaforoAmarillo_2_4();

            //await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));

    //    }
    //}


    IEnumerator trafficLightIEnumerator()
    {
        while (true)
        {

            SemaforoVerde_1_3();
            //print("UnoThree: " + UnoThree);
            //print("TwoFour: " + TwoFour);

            yield return new WaitForSeconds(sliderTimer.timer);
            Semaforo1Amarillo_1_3();

            //print("UnoThree: " + UnoThree);
            //print("TwoFour: " + TwoFour);
            yield return new WaitForSeconds(sliderTimer.timer);
            SemaforoVerde_2_4();
            //print("UnoThree: " + UnoThree);
            //print("TwoFour: " + TwoFour);
            yield return new WaitForSeconds(sliderTimer.timer);
            SemaforoAmarillo_2_4();
            //print("UnoThree: " + UnoThree);
            //print("TwoFour: " + TwoFour);
            yield return new WaitForSeconds(sliderTimer.timer);

        }
    }





    void SemaforoVerde_1_3()
    {
        s1[0].SetActive(true);    // Green
        s1[1].SetActive(false);   // Yellow
        s1[2].SetActive(false);   // Red

        s2[0].SetActive(false);   // Green
        s2[1].SetActive(false);   // Yellow
        s2[2].SetActive(true);    // Red

        s3[0].SetActive(true);    // Green
        s3[1].SetActive(false);   // Yellow
        s3[2].SetActive(false);   // Red

        s4[0].SetActive(false);   // Green
        s4[1].SetActive(false);   // Yellow
        s4[2].SetActive(true);    // Red
        
        UnoThree = true;
        TwoFour = false;
    }

    void Semaforo1Amarillo_1_3()
    {
        s1[0].SetActive(false);  // Green
        s1[1].SetActive(true);   // Yellow
        s1[2].SetActive(false);  // Red

        s2[0].SetActive(false);  // Green
        s2[1].SetActive(false);  // Yellow
        s2[2].SetActive(true);   // Red

        s3[0].SetActive(false);  // Green
        s3[1].SetActive(true);   // Yellow
        s3[2].SetActive(false);  // Red

        s4[0].SetActive(false);  // Green
        s4[1].SetActive(false);  // Yellow
        s4[2].SetActive(true);   // Red
       
        UnoThree = true;
        TwoFour = false;
    }



    void SemaforoVerde_2_4()
    {
        s1[0].SetActive(false);  // Green
        s1[1].SetActive(false);  // Yellow
        s1[2].SetActive(true);   // Red

        s2[0].SetActive(true);   // Green
        s2[1].SetActive(false);  // Yellow
        s2[2].SetActive(false);  // Red

        s3[0].SetActive(false);  // Verde
        s3[1].SetActive(false);  // Yellow
        s3[2].SetActive(true);   // Red

        s4[0].SetActive(true);   // Green
        s4[1].SetActive(false);  // Yellow
        s4[2].SetActive(false);  // Red
       
        UnoThree = false;
        TwoFour = true;
    }

    void SemaforoAmarillo_2_4()
    {
        s1[0].SetActive(false);  // Green
        s1[1].SetActive(false);  // Yellow
        s1[2].SetActive(true);   // Red

        s2[0].SetActive(false);  // Green
        s2[1].SetActive(true);   // Yellow
        s2[2].SetActive(false);  // Red

        s3[0].SetActive(false);  // Green
        s3[1].SetActive(false);  // Yellow
        s3[2].SetActive(true);   // Red

        s4[0].SetActive(false);  // Green
        s4[1].SetActive(true);   // Yellow
        s4[2].SetActive(false);  // Red
        
        UnoThree = false;
        TwoFour = true;
    }


    void allOff()
    {
        //S1
        s1[0].SetActive(false);  // Green
        s1[1].SetActive(false);  // Yellow
        s1[2].SetActive(false);  // Red

        //S2
        s2[0].SetActive(false);  // Green
        s2[1].SetActive(false);  // Yellow
        s2[2].SetActive(false);  // Red

        //S3
        s3[0].SetActive(false);  // Green
        s3[1].SetActive(false);  // Yellow
        s3[2].SetActive(false);  // Red

        //S4
        s4[0].SetActive(false);  // Green
        s4[1].SetActive(false);  // Yellow
        s4[2].SetActive(false);  // Red 
    }
}
