using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003AF RID: 943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobExperienceOtherPlayerUpdateEvent : IMessage<JobExperienceOtherPlayerUpdateEvent>, IMessage, IEquatable<JobExperienceOtherPlayerUpdateEvent>, IDeepCloneable<JobExperienceOtherPlayerUpdateEvent>, IBufferMessage
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x001CD2E8 File Offset: 0x001CB4E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobExperienceOtherPlayerUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x001CD2F8 File Offset: 0x001CB4F8
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

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x001CD308 File Offset: 0x001CB508
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

		// Token: 0x06002C40 RID: 11328 RVA: 0x001CD318 File Offset: 0x001CB518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperienceOtherPlayerUpdateEvent()
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x001CD328 File Offset: 0x001CB528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperienceOtherPlayerUpdateEvent(JobExperienceOtherPlayerUpdateEvent other)
		{
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x001CD338 File Offset: 0x001CB538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperienceOtherPlayerUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x001CD348 File Offset: 0x001CB548
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x001CD358 File Offset: 0x001CB558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JobExperience Experience
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x001CD368 File Offset: 0x001CB568
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x001CD378 File Offset: 0x001CB578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06002C47 RID: 11335 RVA: 0x001CD388 File Offset: 0x001CB588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x001CD398 File Offset: 0x001CB598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobExperienceOtherPlayerUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x001CD3A8 File Offset: 0x001CB5A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x001CD3B8 File Offset: 0x001CB5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x001CD3C8 File Offset: 0x001CB5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x001CD3D8 File Offset: 0x001CB5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x001CD3E8 File Offset: 0x001CB5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x001CD3F8 File Offset: 0x001CB5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobExperienceOtherPlayerUpdateEvent other)
		{
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x001CD408 File Offset: 0x001CB608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x001CD418 File Offset: 0x001CB618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x001CD428 File Offset: 0x001CB628
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobExperienceOtherPlayerUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_B0;
					}
					break;
				}
				IL_88:
				JobExperienceOtherPlayerUpdateEvent._parser = new MessageParser<JobExperienceOtherPlayerUpdateEvent>(() => null);
				num = 2;
				continue;
				IL_B0:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				goto IL_88;
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x001CD4FC File Offset: 0x001CB6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NtK5SlOVadWaKLptgIVe()
		{
			return true;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x001CD504 File Offset: 0x001CB704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobExperienceOtherPlayerUpdateEvent P8pAPQOV5ikH6i0oBDIO()
		{
			return null;
		}

		// Token: 0x04000F90 RID: 3984
		private static readonly MessageParser<JobExperienceOtherPlayerUpdateEvent> _parser;

		// Token: 0x04000F91 RID: 3985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F92 RID: 3986
		public const int ExperienceFieldNumber = 1;

		// Token: 0x04000F93 RID: 3987
		private JobExperience experience_;

		// Token: 0x04000F94 RID: 3988
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000F95 RID: 3989
		private long playerId_;

		// Token: 0x04000F96 RID: 3990
		internal static JobExperienceOtherPlayerUpdateEvent TVpMkZOV1t0FyHxdExoP;
	}
}
