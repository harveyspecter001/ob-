using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006E8 RID: 1768
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangePlayerMultiCraftRequest : IMessage<ExchangePlayerMultiCraftRequest>, IMessage, IEquatable<ExchangePlayerMultiCraftRequest>, IDeepCloneable<ExchangePlayerMultiCraftRequest>, IBufferMessage
	{
		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x00213CB4 File Offset: 0x00211EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangePlayerMultiCraftRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x00213CC4 File Offset: 0x00211EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x00213CD4 File Offset: 0x00211ED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00213CE4 File Offset: 0x00211EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerMultiCraftRequest()
		{
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x00213CF4 File Offset: 0x00211EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerMultiCraftRequest(ExchangePlayerMultiCraftRequest other)
		{
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00213D04 File Offset: 0x00211F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerMultiCraftRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x00213D14 File Offset: 0x00211F14
		// (set) Token: 0x06005683 RID: 22147 RVA: 0x00213D28 File Offset: 0x00211F28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ExchangeType ExchangeType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00213D38 File Offset: 0x00211F38
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x00213D48 File Offset: 0x00211F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x00213D58 File Offset: 0x00211F58
		// (set) Token: 0x06005687 RID: 22151 RVA: 0x00213D68 File Offset: 0x00211F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x06005688 RID: 22152 RVA: 0x00213D78 File Offset: 0x00211F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x00213D88 File Offset: 0x00211F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangePlayerMultiCraftRequest other)
		{
			return true;
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x00213D98 File Offset: 0x00211F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x00213DA8 File Offset: 0x00211FA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x00213DB8 File Offset: 0x00211FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x00213DC8 File Offset: 0x00211FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x00213DD8 File Offset: 0x00211FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x00213DE8 File Offset: 0x00211FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangePlayerMultiCraftRequest other)
		{
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x00213DF8 File Offset: 0x00211FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x00213E08 File Offset: 0x00212008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x00213E18 File Offset: 0x00212018
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangePlayerMultiCraftRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangePlayerMultiCraftRequest._parser = new MessageParser<ExchangePlayerMultiCraftRequest>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x00213EE4 File Offset: 0x002120E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rvqlXvOMrCnXoC8Kl6bQ()
		{
			return true;
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x00213EEC File Offset: 0x002120EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangePlayerMultiCraftRequest F6MOIxOMVmDqnfKPxDQ0()
		{
			return null;
		}

		// Token: 0x04001E51 RID: 7761
		private static readonly MessageParser<ExchangePlayerMultiCraftRequest> _parser;

		// Token: 0x04001E52 RID: 7762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E53 RID: 7763
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001E54 RID: 7764
		private ExchangeType exchangeType_;

		// Token: 0x04001E55 RID: 7765
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04001E56 RID: 7766
		private long targetId_;

		// Token: 0x04001E57 RID: 7767
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04001E58 RID: 7768
		private int skillId_;

		// Token: 0x04001E59 RID: 7769
		internal static ExchangePlayerMultiCraftRequest vSh22jOMhsgX4FsuUxj9;
	}
}
