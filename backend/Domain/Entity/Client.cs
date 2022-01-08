using System;
using System.Collections.Generic;
using Domain.Validators;

namespace Domain.Entity{
    public class Client:Base{

          public string Name  { get; private set; }
          public string Cpf {get; private set; }
          public DateTime BirthDate { get; private set; }

          protected void User(){}

          public void User(
              string name,
              string cpf,
              DateTime birthDate
          ){
              Name = name;
              Cpf = cpf;
              BirthDate = birthDate;
              _errors = new List<string>();
          }

          public void changeName(string name){
              Name = name;
              Validate();
          }
          public void changeCpf(string cpf){
              Cpf = cpf;
              Validate();
          }
          public void changeBirthDate(DateTime birthDate){
              BirthDate = birthDate;
              Validate();
          }

          public override bool Validate(){
              var validator = new ClientValidator();
              var validation = validator.Validate(this);

              if(!validation.IsValid){
                  foreach(var _error in validation.Errors)
                    _errors.Add(_error.ErrorMessage);
                
                throw new Exception("Erro na entidade ! "+  _errors[0]);
                
              }
              return true;
          }
    }
}