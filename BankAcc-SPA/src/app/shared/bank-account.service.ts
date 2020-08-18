import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BankAccountService {

  constructor(private http : HttpClient) { }

  postBankAccount(formData)
  {
    return this.http.post(environment.apiBaseURI + '/BankAccounts',formData)

  }

  getBankAccountList()
  {
    return this.http.get(environment.apiBaseURI+'/BankAccounts')
  }

  putBankAccount(formData)
  {
    return this.http.put('http://localhost:55878/api/BankAccounts/'+formData.bankAccountID,formData)

  }

  deleteBankAccount(id)
  {
    return this.http.delete(environment.apiBaseURI+'/BankAccounts/'+id)
  }
}
