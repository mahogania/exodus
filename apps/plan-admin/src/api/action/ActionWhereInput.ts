import { StringFilter } from "../../util/StringFilter";
import { ObjectWhereUniqueInput } from "../object/ObjectWhereUniqueInput";
import { TaskListRelationFilter } from "../task/TaskListRelationFilter";

export type ActionWhereInput = {
  id?: StringFilter;
  object?: ObjectWhereUniqueInput;
  tasks?: TaskListRelationFilter;
};
