import { DateTimeNullableFilter } from "../../util/DateTimeNullableFilter";
import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";
import { StringFilter } from "../../util/StringFilter";
import { JsonFilter } from "../../util/JsonFilter";

export type EventWhereInput = {
  dateTime?: DateTimeNullableFilter;
  eventType?: EventTypeWhereUniqueInput;
  id?: StringFilter;
  value?: JsonFilter;
};
