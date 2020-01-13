import { Injectable } from '@angular/core';
import { SelectControlValueAccessor } from '@angular/forms';
declare let alertify: any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }

  confirm(message: string, okCallBack: () => any) {
    // tslint:disable-next-line: only-arrow-functions
    // tslint:disable-next-line: space-before-function-paren
    alertify.confirm(message, function (e) {
      if (e) {
        okCallBack();
      } else { }
    });


  }
  success(message: string) {
    alertify.success(message);
  }
  error(message: string) {
    alertify.error(message);
  }
  warning(message: string) {
    alertify.warning(message);
  }
  message(message: string) {
    alertify.message(message);
  }
}
