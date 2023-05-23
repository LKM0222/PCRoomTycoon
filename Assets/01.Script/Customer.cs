using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer{
    string name;
    bool gender;
    int favoriteGame; //code
    int favoriteSeat; //code
    int favoriteFood; //code
    int restTime;
    float evaluation;

    public Customer(string _name, bool _gender, int _favoriteGame, int _favoriteSeat, int _favoriteFood, int _restTime, float _evaluation){
        name = _name;
        gender = _gender;
        favoriteGame = _favoriteGame;
        favoriteSeat = _favoriteSeat;
        favoriteFood = _favoriteFood;
        restTime = _restTime;
        evaluation = _evaluation;
    }

    //get
    public string GetName(){
        return name;
    }

    public bool GetGender(){
        return gender;
    }

    public int GetFavoriteGame(){
        return favoriteGame;
    }

    public int GetFavoriteSeat(){
        return favoriteSeat;
    }

    public int GetFavoriteFood(){
        return favoriteFood;
    }

    public int GetRestTime(){
        return restTime;
    }

    public float GetEvaluation(){
        return evaluation;
    }

    //set
    public void SetName(string _name){
        name = _name;
    }

    public void SetGender(bool _gender){
        gender = _gender;
    }
    public void SetFavoriteGame(int _favoriteGame){
        favoriteGame = _favoriteGame;
    }

    public void SetFavoriteSeat(int _favoriteSeat){
        favoriteSeat = _favoriteSeat;
    }
    public void SetFavoriteFood(int _favoriteFood){
        favoriteFood = _favoriteFood;
    }
    public void SetRestTime(int _restTime){
        restTime = _restTime;
    }

    public void SetEvaluation(float _evaluation){
        evaluation = _evaluation;
    }
}
