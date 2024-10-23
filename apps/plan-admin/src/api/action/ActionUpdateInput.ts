import { ObjectWhereUniqueInput } from "../object/ObjectWhereUniqueInput";
import { TaskUpdateManyWithoutActionsInput } from "./TaskUpdateManyWithoutActionsInput";

export type ActionUpdateInput = {
  object?: ObjectWhereUniqueInput | null;
  tasks?: TaskUpdateManyWithoutActionsInput;
};
