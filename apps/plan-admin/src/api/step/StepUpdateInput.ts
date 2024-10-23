import { TaskUpdateManyWithoutStepsInput } from "./TaskUpdateManyWithoutStepsInput";
import { WorkflowWhereUniqueInput } from "../workflow/WorkflowWhereUniqueInput";

export type StepUpdateInput = {
  kind?:
    | "Enable"
    | "Concurrent"
    | "Choice"
    | "Disable"
    | "Suspend"
    | "Independent"
    | null;
  tasks?: TaskUpdateManyWithoutStepsInput;
  workflow?: WorkflowWhereUniqueInput | null;
};
