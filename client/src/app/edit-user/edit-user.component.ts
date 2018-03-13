import { Component, Injector } from '@angular/core';
import { EditUserGenerated } from './edit-user-generated.component';

@Component({
  selector: 'edit-user',
  templateUrl: './edit-user.component.html'
})
export class EditUserComponent extends EditUserGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
