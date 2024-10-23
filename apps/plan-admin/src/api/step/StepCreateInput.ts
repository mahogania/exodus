import { TaskCreateNestedManyWithoutStepsInput } from "./TaskCreateNestedManyWithoutStepsInput";
import { WorkflowWhereUniqueInput } from "../workflow/WorkflowWhereUniqueInput";

export type StepCreateInput = {
  kind?:
    | "Enable"
    | "Concurrent"
    | "Choice"
    | "Disable"
    | "Suspend"
    | "Independent"
    | null;
  tasks?: TaskCreateNestedManyWithoutStepsInput;
  workflow?: WorkflowWhereUniqueInput | null;
};
