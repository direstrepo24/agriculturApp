import { Component, Injector } from '@angular/core';
import { AddLocalizacionUpGenerated } from './add-localizacion-up-generated.component';

@Component({
  selector: 'add-localizacion-up',
  templateUrl: './add-localizacion-up.component.html'
})
export class AddLocalizacionUpComponent extends AddLocalizacionUpGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
