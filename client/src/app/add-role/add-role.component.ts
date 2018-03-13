import { Component, Injector } from '@angular/core';
import { AddRoleGenerated } from './add-role-generated.component';

@Component({
  selector: 'add-role',
  templateUrl: './add-role.component.html'
})
export class AddRoleComponent extends AddRoleGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
