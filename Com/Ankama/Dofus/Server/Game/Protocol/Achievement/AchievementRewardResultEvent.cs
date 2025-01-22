using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DCF RID: 3535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementRewardResultEvent : IMessage<AchievementRewardResultEvent>, IMessage, IEquatable<AchievementRewardResultEvent>, IDeepCloneable<AchievementRewardResultEvent>, IBufferMessage
	{
		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x0600AA54 RID: 43604 RVA: 0x00298CA0 File Offset: 0x00296EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementRewardResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x0600AA55 RID: 43605 RVA: 0x00298CB0 File Offset: 0x00296EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x00298CC0 File Offset: 0x00296EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x00298CD0 File Offset: 0x00296ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardResultEvent()
		{
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x00298CE0 File Offset: 0x00296EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardResultEvent(AchievementRewardResultEvent other)
		{
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x00298CF0 File Offset: 0x00296EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementRewardResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x00298D00 File Offset: 0x00296F00
		// (set) Token: 0x0600AA5B RID: 43611 RVA: 0x00298D10 File Offset: 0x00296F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AchievementId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600AA5C RID: 43612 RVA: 0x00298D20 File Offset: 0x00296F20
		// (set) Token: 0x0600AA5D RID: 43613 RVA: 0x00298D30 File Offset: 0x00296F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x00298D40 File Offset: 0x00296F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x00298D50 File Offset: 0x00296F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementRewardResultEvent other)
		{
			return true;
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x00298D60 File Offset: 0x00296F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x00298D70 File Offset: 0x00296F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x00298D80 File Offset: 0x00296F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x00298D90 File Offset: 0x00296F90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x00298DA0 File Offset: 0x00296FA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x00298DB0 File Offset: 0x00296FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementRewardResultEvent other)
		{
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x00298DC0 File Offset: 0x00296FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x00298DD0 File Offset: 0x00296FD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x00298DE0 File Offset: 0x00296FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementRewardResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AchievementRewardResultEvent._parser = new MessageParser<AchievementRewardResultEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x00298EAC File Offset: 0x002970AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sePVJmJcrGgaQO0FlWIO()
		{
			return true;
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x00298EB4 File Offset: 0x002970B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementRewardResultEvent qTyEvAJcVDYPL4k2BnGL()
		{
			return null;
		}

		// Token: 0x04003E8A RID: 16010
		private static readonly MessageParser<AchievementRewardResultEvent> _parser;

		// Token: 0x04003E8B RID: 16011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E8C RID: 16012
		public const int AchievementIdFieldNumber = 1;

		// Token: 0x04003E8D RID: 16013
		private int achievementId_;

		// Token: 0x04003E8E RID: 16014
		public const int SuccessFieldNumber = 2;

		// Token: 0x04003E8F RID: 16015
		private bool success_;

		// Token: 0x04003E90 RID: 16016
		private static AchievementRewardResultEvent amYjhaJchKQKrYFVHLTS;
	}
}
