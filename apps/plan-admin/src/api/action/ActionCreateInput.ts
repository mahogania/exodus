import { ObjectWhereUniqueInput } from "../object/ObjectWhereUniqueInput";
import { TaskCreateNestedManyWithoutActionsInput } from "./TaskCreateNestedManyWithoutActionsInput";

export type ActionCreateInput = {
  object?: ObjectWhereUniqueInput | null;
  tasks?: TaskCreateNestedManyWithoutActionsInput;
};
