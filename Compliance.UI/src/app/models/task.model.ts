import { Category, Priority, Status } from '../enums/enums';

export interface ComplianceTask {
  taskID: number;
  taskIDFactorial: number | null;
  category: Category;
  description?: string;
  dueDate: Date;
  priority: Priority;
  status: Status;
}
