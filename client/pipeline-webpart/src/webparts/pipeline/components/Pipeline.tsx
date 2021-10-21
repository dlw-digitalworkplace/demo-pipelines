import * as React from "react";
import styles from "./Pipeline.module.scss";
import { IPipelineProps } from "./IPipelineProps";
import { escape } from "@microsoft/sp-lodash-subset";

export default class Pipeline extends React.Component<IPipelineProps, {}> {
  public render(): React.ReactElement<IPipelineProps> {
    return (
      <div className={styles.pipeline}>
        <div className={styles.container}>
          <div className={styles.row}>
            <div className={styles.column}>
              <span className={styles.title}>
                Pipeline web part CHANGE - {process.env.SPFX_MY_ENV}
              </span>
              <p className={styles.subTitle}>Make pipelines great again!</p>
              <p className={styles.description}>
                {escape(this.props.description)}
              </p>
              <a href="https://aka.ms/spfx" className={styles.button}>
                <span className={styles.label}>Learn more</span>
              </a>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
