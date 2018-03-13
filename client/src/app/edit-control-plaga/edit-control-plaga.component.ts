import { Component, Injector } from '@angular/core';
import { EditControlPlagaGenerated } from './edit-control-plaga-generated.component';

@Component({
  selector: 'edit-control-plaga',
  templateUrl: './edit-control-plaga.component.html'
})
export class EditControlPlagaComponent extends EditControlPlagaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
