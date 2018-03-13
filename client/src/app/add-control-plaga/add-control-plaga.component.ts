import { Component, Injector } from '@angular/core';
import { AddControlPlagaGenerated } from './add-control-plaga-generated.component';

@Component({
  selector: 'add-control-plaga',
  templateUrl: './add-control-plaga.component.html'
})
export class AddControlPlagaComponent extends AddControlPlagaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
