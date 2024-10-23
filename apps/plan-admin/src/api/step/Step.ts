import { Task } from "../task/Task";
import { Workflow } from "../workflow/Workflow";

export type Step = {
  createdAt: Date;
  id: string;
  kind?:
    | "Enable"
    | "Concurrent"
    | "Choice"
    | "Disable"
    | "Suspend"
    | "Independent"
    | null;
  tasks?: Array<Task>;
  updatedAt: Date;
  workflow?: Workflow | null;
};
