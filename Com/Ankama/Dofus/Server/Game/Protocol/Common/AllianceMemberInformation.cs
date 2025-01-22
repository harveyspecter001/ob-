using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A6B RID: 2667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMemberInformation : IMessage<AllianceMemberInformation>, IMessage, IEquatable<AllianceMemberInformation>, IDeepCloneable<AllianceMemberInformation>, IBufferMessage
	{
		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x0025E9A8 File Offset: 0x0025CBA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceMemberInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06007F2F RID: 32559 RVA: 0x0025E9B8 File Offset: 0x0025CBB8
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

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06007F30 RID: 32560 RVA: 0x0025E9C8 File Offset: 0x0025CBC8
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

		// Token: 0x06007F31 RID: 32561 RVA: 0x0025E9D8 File Offset: 0x0025CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberInformation()
		{
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x0025E9E8 File Offset: 0x0025CBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberInformation(AllianceMemberInformation other)
		{
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x0025E9F8 File Offset: 0x0025CBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberInformation Clone()
		{
			return null;
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06007F34 RID: 32564 RVA: 0x0025EA08 File Offset: 0x0025CC08
		// (set) Token: 0x06007F35 RID: 32565 RVA: 0x0025EA18 File Offset: 0x0025CC18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character Information
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

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06007F36 RID: 32566 RVA: 0x0025EA28 File Offset: 0x0025CC28
		// (set) Token: 0x06007F37 RID: 32567 RVA: 0x0025EA38 File Offset: 0x0025CC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AvaRoleId
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

		// Token: 0x06007F38 RID: 32568 RVA: 0x0025EA48 File Offset: 0x0025CC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x0025EA58 File Offset: 0x0025CC58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMemberInformation other)
		{
			return true;
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x0025EA68 File Offset: 0x0025CC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x0025EA78 File Offset: 0x0025CC78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x0025EA88 File Offset: 0x0025CC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x0025EA98 File Offset: 0x0025CC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x0025EAA8 File Offset: 0x0025CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x0025EAB8 File Offset: 0x0025CCB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMemberInformation other)
		{
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x0025EAC8 File Offset: 0x0025CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x0025EAD8 File Offset: 0x0025CCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x0025EAE8 File Offset: 0x0025CCE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMemberInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AllianceMemberInformation._parser = new MessageParser<AllianceMemberInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x0025EBE0 File Offset: 0x0025CDE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H0UWTcJGMucfM3yGxkY6()
		{
			return true;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x0025EBE8 File Offset: 0x0025CDE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMemberInformation WGqQF6JGuEf9e64MQxCv()
		{
			return null;
		}

		// Token: 0x04002E06 RID: 11782
		private static readonly MessageParser<AllianceMemberInformation> _parser;

		// Token: 0x04002E07 RID: 11783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E08 RID: 11784
		public const int InformationFieldNumber = 1;

		// Token: 0x04002E09 RID: 11785
		private Character information_;

		// Token: 0x04002E0A RID: 11786
		public const int AvaRoleIdFieldNumber = 2;

		// Token: 0x04002E0B RID: 11787
		private int avaRoleId_;

		// Token: 0x04002E0C RID: 11788
		internal static AllianceMemberInformation S9inAeJGSOqI2l02RVXV;
	}
}
