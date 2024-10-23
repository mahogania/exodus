import * as React from "react";

import {
  Create,
  SimpleForm,
  CreateProps,
  SelectInput,
  ReferenceArrayInput,
  SelectArrayInput,
  ReferenceInput,
} from "react-admin";

import { TaskTitle } from "../task/TaskTitle";
import { WorkflowTitle } from "../workflow/WorkflowTitle";

export const StepCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <SelectInput
          source="kind"
          label="Kind"
          choices={[
            { label: "Enable", value: "Enable" },
            { label: "Concurrent", value: "Concurrent" },
            { label: "Choice", value: "Choice" },
            { label: "Disable", value: "Disable" },
            { label: "Suspend", value: "Suspend" },
            { label: "Independent", value: "Independent" },
          ]}
          optionText="label"
          allowEmpty
          optionValue="value"
        />
        <ReferenceArrayInput source="tasks" reference="Task">
          <SelectArrayInput
            optionText={TaskTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <ReferenceInput
          source="workflow.id"
          reference="Workflow"
          label="Workflow"
        >
          <SelectInput optionText={WorkflowTitle} />
        </ReferenceInput>
      </SimpleForm>
    </Create>
  );
};
