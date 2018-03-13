import { Component, Injector } from '@angular/core';
import { AddRolGenerated } from './add-rol-generated.component';

@Component({
  selector: 'add-rol',
  templateUrl: './add-rol.component.html'
})
export class AddRolComponent extends AddRolGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
