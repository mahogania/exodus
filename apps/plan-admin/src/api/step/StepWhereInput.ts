import { StringFilter } from "../../util/StringFilter";
import { TaskListRelationFilter } from "../task/TaskListRelationFilter";
import { WorkflowWhereUniqueInput } from "../workflow/WorkflowWhereUniqueInput";

export type StepWhereInput = {
  id?: StringFilter;
  kind?:
    | "Enable"
    | "Concurrent"
    | "Choice"
    | "Disable"
    | "Suspend"
    | "Independent";
  tasks?: TaskListRelationFilter;
  workflow?: WorkflowWhereUniqueInput;
};
