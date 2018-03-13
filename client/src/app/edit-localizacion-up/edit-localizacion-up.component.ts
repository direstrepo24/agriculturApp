import { Component, Injector } from '@angular/core';
import { EditLocalizacionUpGenerated } from './edit-localizacion-up-generated.component';

@Component({
  selector: 'edit-localizacion-up',
  templateUrl: './edit-localizacion-up.component.html'
})
export class EditLocalizacionUpComponent extends EditLocalizacionUpGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
