import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";
import { InputJsonValue } from "../../types";

export type EventUpdateInput = {
  dateTime?: Date | null;
  eventType?: EventTypeWhereUniqueInput | null;
  value?: InputJsonValue;
};
