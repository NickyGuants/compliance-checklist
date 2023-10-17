import { Component, EventEmitter, Output } from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Category, Priority, Status} from 'src/app/enums/enums';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap'; // <-- Import NgbActiveModal
import {ComplianceTaskService} from 'src/app/services/compliance-task.service';
import {ComplianceTaskRequest} from 'src/app/models/task.request';
import {ComplianceTask} from 'src/app/models/task.model';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent {
    category = new FormControl('', Validators.required);
    description = new FormControl('');
    dueDate = new FormControl('', Validators.required);
    priority = new FormControl('', Validators.required);
    status = new FormControl('', Validators.required);

    taskForm = new FormGroup({
      category: this.category,
      description: this.description,
      dueDate: this.dueDate,
      priority: this.priority,
      status: this.status
    });

  CategoryEnum = Object.values(Category).filter(value => isNaN(Number(value)));
  PriorityEnum = Object.values(Priority).filter(value => isNaN(Number(value)));;
  StatusEnum = Object.values(Status).filter(value => isNaN(Number(value)));;
  
  @Output() taskAdded = new EventEmitter<ComplianceTask>();

    constructor(public activeModal: NgbActiveModal,private taskService: ComplianceTaskService) {} 

    onSubmit() {
      if (this.taskForm.valid) {
        const formValues = this.taskForm.value;

        let dueDateValue: Date | undefined;

        if (formValues.dueDate) {
          dueDateValue = new Date(formValues.dueDate);
        }

        const newTask: ComplianceTaskRequest = {
          category: Category[formValues.category as keyof typeof Category],
          description: formValues.description || undefined,
          dueDate: dueDateValue,
          priority: Priority[formValues.priority as keyof typeof Priority],
          status: Status[formValues.status as keyof typeof Status]
        };

        this.taskService.addTask(newTask).subscribe(response => {
          this.taskAdded.emit(response);
          this.close();
        });
      }
    }

  close() {
    this.activeModal.close(); 
  }
}
