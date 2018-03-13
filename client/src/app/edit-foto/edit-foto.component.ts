import { Component, Injector } from '@angular/core';
import { EditFotoGenerated } from './edit-foto-generated.component';

@Component({
  selector: 'edit-foto',
  templateUrl: './edit-foto.component.html'
})
export class EditFotoComponent extends EditFotoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
