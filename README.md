# 森林冰火人

## 项目概述
森林冰火人是一个动作冒险游戏，玩家控制冰火娃通过各种障碍达到终点。游戏特色包括角色的奔跑、跳跃以及与环境的互动，如电梯和各种动画效果。

## 主要功能

### 动作控制
- **奔跑和跳跃**：通过设定初始向下的速度和时钟事件来检测和更新角色位置，确保不会与障碍物重合。
- **重力处理**：使用相似逻辑处理动态障碍物如砖块，确保其按物理规律运动。

### 交互设备
- **电梯控制**：游戏中的电梯可以通过角色位置动态上升或下降，提高互动性和游戏难度。
- **动画效果**：包括冰火池和毒池的动态效果，以及角色死亡和成功过关的特效。

### 音效
- 游戏包含两种背景音乐，分别适用于菜单和游戏界面，以及多种游戏效果音，增强沉浸感。

## 开发环境

### 工具和技术
- **编程语言**：C#
- **开发工具**：Microsoft Visual Studio
- **图形界面**：Windows Forms

## 难点及解决方案
- **重力问题**：通过精细的速度控制和位置更新，避免角色穿过障碍物。
- **多方向移动**：通过键盘事件控制速度，而非直接位移，以实现平滑移动。
- **电梯互动**：特定的逻辑确保电梯与角色在同一时间内正确响应移动命令。

## 操作说明
- **冰娃控制**
  - `W`：上升
  - `A`：左移
  - `D`：右移
- **火娃控制**
  - `Ctrl+Up`：上升
  - `Ctrl+Left`：左移
  - `Ctrl+Right`：右移

## 许可
本项目遵循MIT许可证。详情见LICENSE文件。
