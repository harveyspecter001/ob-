using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D53 RID: 3411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMemberStartWarningOnConnectionRequest : IMessage<AllianceMemberStartWarningOnConnectionRequest>, IMessage, IEquatable<AllianceMemberStartWarningOnConnectionRequest>, IDeepCloneable<AllianceMemberStartWarningOnConnectionRequest>, IBufferMessage
	{
		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x0028F23C File Offset: 0x0028D43C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceMemberStartWarningOnConnectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x0600A45A RID: 42074 RVA: 0x0028F24C File Offset: 0x0028D44C
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

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x0028F25C File Offset: 0x0028D45C
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

		// Token: 0x0600A45C RID: 42076 RVA: 0x0028F26C File Offset: 0x0028D46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStartWarningOnConnectionRequest()
		{
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x0028F27C File Offset: 0x0028D47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStartWarningOnConnectionRequest(AllianceMemberStartWarningOnConnectionRequest other)
		{
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x0028F28C File Offset: 0x0028D48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberStartWarningOnConnectionRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x0028F29C File Offset: 0x0028D49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x0028F2AC File Offset: 0x0028D4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMemberStartWarningOnConnectionRequest other)
		{
			return true;
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x0028F2BC File Offset: 0x0028D4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x0028F2CC File Offset: 0x0028D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x0028F2DC File Offset: 0x0028D4DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x0028F2EC File Offset: 0x0028D4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x0028F2FC File Offset: 0x0028D4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x0028F30C File Offset: 0x0028D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMemberStartWarningOnConnectionRequest other)
		{
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x0028F31C File Offset: 0x0028D51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x0028F32C File Offset: 0x0028D52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x0028F33C File Offset: 0x0028D53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMemberStartWarningOnConnectionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceMemberStartWarningOnConnectionRequest._parser = new MessageParser<AllianceMemberStartWarningOnConnectionRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x0028F420 File Offset: 0x0028D620
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G1aAklJIuWtlHHJpOkyF()
		{
			return true;
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x0028F428 File Offset: 0x0028D628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMemberStartWarningOnConnectionRequest jg7LT7JI8tnhPyYFdAVr()
		{
			return null;
		}

		// Token: 0x04003C8F RID: 15503
		private static readonly MessageParser<AllianceMemberStartWarningOnConnectionRequest> _parser;

		// Token: 0x04003C90 RID: 15504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C91 RID: 15505
		private static AllianceMemberStartWarningOnConnectionRequest tcfg1BJIMdqyRodqZCHK;
	}
}
