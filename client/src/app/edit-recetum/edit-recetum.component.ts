import { Component, Injector } from '@angular/core';
import { EditRecetumGenerated } from './edit-recetum-generated.component';

@Component({
  selector: 'edit-recetum',
  templateUrl: './edit-recetum.component.html'
})
export class EditRecetumComponent extends EditRecetumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
