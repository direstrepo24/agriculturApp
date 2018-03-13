import { Component, Injector } from '@angular/core';
import { AddUserGenerated } from './add-user-generated.component';

@Component({
  selector: 'add-user',
  templateUrl: './add-user.component.html'
})
export class AddUserComponent extends AddUserGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
