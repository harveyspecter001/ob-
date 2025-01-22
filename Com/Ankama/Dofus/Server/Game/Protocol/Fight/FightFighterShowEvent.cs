using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000688 RID: 1672
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFighterShowEvent : IMessage<FightFighterShowEvent>, IMessage, IEquatable<FightFighterShowEvent>, IDeepCloneable<FightFighterShowEvent>, IBufferMessage
	{
		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x0600518D RID: 20877 RVA: 0x002061EC File Offset: 0x002043EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFighterShowEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x002061FC File Offset: 0x002043FC
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600518F RID: 20879 RVA: 0x0020620C File Offset: 0x0020440C
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

		// Token: 0x06005190 RID: 20880 RVA: 0x0020621C File Offset: 0x0020441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterShowEvent()
		{
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x0020622C File Offset: 0x0020442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterShowEvent(FightFighterShowEvent other)
		{
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x0020623C File Offset: 0x0020443C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterShowEvent Clone()
		{
			return null;
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x0020624C File Offset: 0x0020444C
		// (set) Token: 0x06005194 RID: 20884 RVA: 0x0020625C File Offset: 0x0020445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorPositionInformation Information
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x0020626C File Offset: 0x0020446C
		// (set) Token: 0x06005196 RID: 20886 RVA: 0x0020627C File Offset: 0x0020447C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool StaticPose
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

		// Token: 0x06005197 RID: 20887 RVA: 0x0020628C File Offset: 0x0020448C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x0020629C File Offset: 0x0020449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightFighterShowEvent other)
		{
			return true;
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x002062AC File Offset: 0x002044AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x002062BC File Offset: 0x002044BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x002062CC File Offset: 0x002044CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x002062DC File Offset: 0x002044DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x002062EC File Offset: 0x002044EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x002062FC File Offset: 0x002044FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightFighterShowEvent other)
		{
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0020630C File Offset: 0x0020450C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0020631C File Offset: 0x0020451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0020632C File Offset: 0x0020452C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightFighterShowEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightFighterShowEvent._parser = new MessageParser<FightFighterShowEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x002063F8 File Offset: 0x002045F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JUpor8OPNlb0LAHpu52t()
		{
			return true;
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00206400 File Offset: 0x00204600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightFighterShowEvent SvOr5OOPxRd3xrDirT7s()
		{
			return null;
		}

		// Token: 0x04001CA8 RID: 7336
		private static readonly MessageParser<FightFighterShowEvent> _parser;

		// Token: 0x04001CA9 RID: 7337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CAA RID: 7338
		public const int InformationFieldNumber = 1;

		// Token: 0x04001CAB RID: 7339
		private ActorPositionInformation information_;

		// Token: 0x04001CAC RID: 7340
		public const int StaticPoseFieldNumber = 2;

		// Token: 0x04001CAD RID: 7341
		private bool staticPose_;

		// Token: 0x04001CAE RID: 7342
		internal static FightFighterShowEvent G3s6dqOPXKA2I67tE7UE;
	}
}
