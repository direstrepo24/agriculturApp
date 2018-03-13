import { Component, Injector } from '@angular/core';
import { EditRolGenerated } from './edit-rol-generated.component';

@Component({
  selector: 'edit-rol',
  templateUrl: './edit-rol.component.html'
})
export class EditRolComponent extends EditRolGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
